
#pragma warning disable CS8618

using Microsoft.VisualBasic;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using TcgPlayerPricesWFA;

public class ThreadHandler
{
    public static Thread threadForm1 { get; set; }
    public static Thread threadForm2 { get; set; }
    public static void GenerateMainThread()
    {
        threadForm1 = new Thread((ThreadStart)delegate { Application.Run(new Form1()); }); //Initialize a new Thread of name myThread to call Application.Run() on a new instance of ViewSecond                                                                                      //myThread.TrySetApartmentState(ApartmentState.STA); //If you receive errors, comment this out; use this when doing interop with STA COM objects.
        threadForm1.Start(); //Start the thread; Run the form
    }

    public static void PlotPoints(LineSeries lineSeries, double x, double y)
    {

        lineSeries.Points.Add(new DataPoint(x, y));

    }

    public static void GenerateAxesis(PlotView myPlotView)
    {
        var xAxis = new DateTimeAxis
        {
            Position = AxisPosition.Bottom,
            Title = "Date",
            IntervalLength = 75,
            MinorIntervalType = DateTimeIntervalType.Days,
            IntervalType = DateTimeIntervalType.Days,
            MajorGridlineStyle = LineStyle.Solid,
            MinorGridlineStyle = LineStyle.None,
        };

        var yAxis = new LinearAxis
        {
            Position = AxisPosition.Left,
            Title = "Value",
            MajorGridlineStyle = LineStyle.Solid,
            MinorGridlineStyle = LineStyle.None
        };

        myPlotView.Model.Axes.Add(xAxis);
        myPlotView.Model.Axes.Add(yAxis);
    }

    public static PlotView GeneratePlotView()
    {
        return new PlotView()
        {
            Width = 650,
            Height = 350,
            Model = new PlotModel() { },
        };
    }

    public static void GenerateModel(PlotView plot1, LineSeries lineSeries)
    {
        plot1.Model.Series.Add(lineSeries);
    }

    public static void DisplayForm2(PlotView _mView, PlotView _qView, PlotView _sView, PlotView _aView, string _cardName, string _cardNumber, string _cardRarity)
    {
        Form2 newForm = new Form2(_mView, _qView, _sView, _aView);
        newForm.Text = _cardName + " :: " + _cardNumber + " // " + _cardRarity;

        threadForm2 = new Thread((ThreadStart)delegate { Application.Run(newForm); }); //Initialize a new Thread of name myThread to call Application.Run() on a new instance of ViewSecond                                                                                      //myThread.TrySetApartmentState(ApartmentState.STA); //If you receive errors, comment this out; use this when doing interop with STA COM objects.
        threadForm2.Start(); //Start the thread; Run the form
    }
}