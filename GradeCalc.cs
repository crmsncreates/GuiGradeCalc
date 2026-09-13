namespace GuiGradeCalc
{
    public partial class GradeCalc : Form
    {
        public GradeCalc()
        {
            InitializeComponent();
        }


        //# APPLICATION BEHAVIOR

        public IEnumerable<ListViewItem> Grades => viewGrades.Items.Cast<ListViewItem>();

        public void AddGrade(ListViewItem item)
        {
            viewGrades.Items.Add(item);
            RefreshAverageGrade();
        }

        public void AddGrades(params IEnumerable<ListViewItem> items)
        {
            viewGrades.Items.AddRange([..items]);
            RefreshAverageGrade();
        }

        public void ClearGrades()
        {
            viewGrades.Clear();
            RefreshAverageGrade();
        }

        public void RemoveGrade(ListViewItem item)
        {
            viewGrades.Items.Remove(item);
            RefreshAverageGrade();
        }

        public void RemoveGrades(params IEnumerable<ListViewItem> items)
        {
            viewGrades.BeginUpdate();
            try
            {
                foreach (var item in items)
                {
                    viewGrades.Items.Remove(item);
                }
            }
            finally
            {
                viewGrades.EndUpdate();
            }
            RefreshAverageGrade();
        }

        public void LoadCsv(ReadOnlySpan<char> csv)
        {
            viewGrades.BeginUpdate();
            try
            {
                List<ListViewItem> gradesToAdd = [];
                for (var lines = csv.EnumerateLines(); lines.MoveNext();)
                {
                    var line = lines.Current;
                    for (var itemRanges = line.Split(','); itemRanges.MoveNext();)
                    {
                        var text = line[itemRanges.Current].Trim();
                        if (!decimal.TryParse(text, out var value))
                        {
                            MessageBox.Show($"CSV must contain only numeric values, but file contained `{text}`.");
                            break;
                        }
                        if (value is < 0 or > 100)
                        {
                            MessageBox.Show($"CSV must contain only values from 0..100, but file contained `{text}`.");
                            break;
                        }
                        gradesToAdd.Add(new ListViewItem
                        {
                            Text = text.ToString(),
                            Tag = value,
                        });
                    }
                }
                AddGrades(gradesToAdd);
            }
            finally
            {
                viewGrades.EndUpdate();
            }
            RefreshAverageGrade();
        }

        protected void RefreshAverageGrade()
        {
            var avg = Grades
                .Select(static li => li.Tag as decimal? ?? 0.0m)
                .DefaultIfEmpty(0.0m)
                .Average();
            lblResult.Text = $"Average Grade: {avg:0.00}";
        }


        //# EVENT HANDLERS

        private void GradeCalc_Load(object sender, EventArgs e)
        {
            ClearGrades();
        }

        private void ViewGrades_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (!decimal.TryParse(e.Label, out var value))
            {
                e.CancelEdit = true;
                MessageBox.Show("Input must be numeric.");
                return;
            }
            if (value is < 0 or > 100)
            {
                e.CancelEdit = true;
                MessageBox.Show("Input must be between 0 and 100.");
                return;
            }
            viewGrades.Items[e.Item].Tag = value;
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            AddGrade(new ListViewItem
            {
                Text = inputGrade.Value.ToString(),
                Tag = inputGrade.Value,
            });
            RefreshAverageGrade();
        }

        private void BtnDelGrades_Click(object sender, EventArgs e)
        {
            RemoveGrades(items: viewGrades.SelectedItems.Cast<ListViewItem>());
        }

        private void BtnClearGrades_Click(object sender, EventArgs e)
        {
            ClearGrades();
        }

        private void BtnLoadCsv_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 2,
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            using var fileStream = dialog.OpenFile();
            using var reader = new StreamReader(fileStream);
            LoadCsv(reader.ReadToEnd());
        }
    }
}
