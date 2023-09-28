using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DifficultyOfSortingAlgorithms;
public partial class OperationForm : Form
{
    private Excel.Application _excel;
    private Excel.Workbook _workbook;
    private Excel.Worksheet _worksheet;
    private Excel.Chart _listGraph;

    private readonly SortingAlgorithm[] _sortingAlgorithms;

    public OperationForm()
    {
        _sortingAlgorithms = new SortingAlgorithm[] { 
            new Bubblesort("Bubblesort"),
            new ImprovedBubblesort("ImprovedBubblesort"),
            new InsertionSort("InsertionSort"),
            new MinMax("MinMax"),
            new Mergesort("Mergesort") };
        InitializeComponent();
    }

    private void btnLaunchExcel_Click(object sender, EventArgs e)
    {
        _excel = new Excel.Application
        {
            Visible = true
        };
        _workbook = _excel.Workbooks.Add(Type.Missing);
        _worksheet = (Excel.Worksheet)_workbook.ActiveSheet;

        btnDrawGraphDifficulty.Enabled = true;
        btnLaunchExcel.Enabled = false;
    }

    private void btnDrawGraphDifficulty_Click(object sender, EventArgs e)
    {
        btnDrawGraphDifficulty.Enabled = false;
        var iterations = Convert.ToInt32(numericUpDown1.Text);
        _worksheet.Name = "Sorting Algorithms Data";

        _worksheet.Cells[1, 1] = "Graph";
        for (var j = 2; j <= iterations + 1; j++)
        {
            _worksheet.Cells[j, 1] = "ms";
        }
        
        for (var o = 0; o < _sortingAlgorithms.Length; o++)
        {
            var currentAlgorithm = _sortingAlgorithms[o];
            _worksheet.Cells[1, 2 + o] = currentAlgorithm.Name;
            for (var i = 1; i <= iterations; i++)
            {
                var sortingArray = new int[100 * i * i];
                Populate.Array(sortingArray);
                _worksheet.Cells[1 + i, 2 + o] = currentAlgorithm.Sort(sortingArray).Time.ElapsedMilliseconds;
            }
        }

        _listGraph = (Excel.Chart)_workbook.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        _listGraph.Name = "Sorting Algorithms Graph";
        _listGraph.ChartType = Excel.XlChartType.xlXYScatterSmoothNoMarkers;
        _listGraph.SetSourceData(
            _worksheet.Range[
                _worksheet.Cells[1, 1],
                _worksheet.Cells[iterations + 1, _sortingAlgorithms.Length + 1]],
            Excel.XlRowCol.xlColumns);
        _listGraph.HasTitle = true;
        _listGraph.ChartStyle = 209;
        _listGraph.ChartTitle.Text = "Difficulty graph";
        _listGraph.ChartTitle.Font.Size = 20;
    }
}