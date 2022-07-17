using EDFCSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleEDF
{
    public partial class MainForm : Form
    {
        EDFFile file = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenEdfButtonClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "EDF File|*.edf" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Task.Run(delegate
                {
                    Invoke(new Action(delegate
                    {
                        openEdfButton.Enabled = false;
                        stateLabel.Text = "Loading...";
                    }));

                    file = new EDFFile(ofd.FileName);

                    Invoke(new Action(delegate
                    {
                        var header = file.Header;

                        edfHeaderContentLabel.Text =
                            header.FirstRecordTime + "\r\n" +
                            header.NumberOfDataRecords.Value + "\r\n" +
                            IListToStr(header.DigitalMaximums.Value) + "\r\n" +
                            IListToStr(header.DigitalMinimums.Value) + "\r\n" +
                            IListToStr(header.PhysicalMaximums.Value) + "\r\n" +
                            IListToStr(header.PhysicalMinimums.Value) + "\r\n" +
                            IListToStr(header.PhysicalDimensions.Value) + "\r\n" +
                            IListToStr(header.TransducerTypes.Value) + "\r\n" +
                            IListToStr(header.Labels.Value) + "\r\n" +
                            header.NumberOfSignalsInRecord.Value + "\r\n" +
                            header.RecordDurationInSeconds.Value + "\r\n" +
                            header.NumberOfDataRecords.Value + "\r\n" +
                            header.Reserved.Value + "\r\n" +
                            header.SizeInBytes.Value + "\r\n" +
                            header.RecordingStartTime.Value + "\r\n" +
                            header.RecordingStartDate.Value + "\r\n" +
                            header.RecordID.Value + "\r\n" +
                            header.PatientID.Value + "\r\n" +
                            header.Version.Value + "\r\n" +
                            IListToStr(header.SignalsReserved.Value) + "\r\n" +
                            header.TotalDurationInSeconds;

                        //使panel显示滚动条
                        edfHeaderPanel.Controls.Add(new Control { Top = edfHeaderContentLabel.Bottom, Left = edfHeaderContentLabel.Right, Width = 1, Height = 1 });
                    }));

                    foreach (var signal in file.Signals)
                    {
                        Series series = new Series();

                        for (int i = 0, step = (int)Math.Ceiling(signal.SamplesCount / 1e3); i < signal.SamplesCount; i += step) //最多画1000个点，防止内存溢出
                            series.Points.AddXY(i, signal.Samples[i]);

                        series.ChartType = SeriesChartType.Line;
                        series.ChartArea = "CA";

                        Invoke(new Action(delegate
                        {
                            Chart chart = new Chart();
                            ChartArea chartArea = new ChartArea { Name = "CA" };

                            chartArea.AxisX.MajorGrid.LineColor = Color.Transparent;
                            chartArea.AxisY.MajorGrid.LineColor = Color.Transparent;

                            chart.ChartAreas.Add(chartArea);
                            chart.Series.Add(series);
                            chart.Titles.Add(signal.Label.Value);
                            chart.Top = (edfSignalChartPanel.Controls.Count == 0 ? 0 : edfSignalChartPanel.Controls[edfSignalChartPanel.Controls.Count - 1].Bottom) + 5;
                            chart.Left = 0;
                            chart.Width = edfSignalChartPanel.Width;
                            chart.Height = 200;
                            chart.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

                            edfSignalChartPanel.Controls.Add(chart);
                        }));
                    }

                    Invoke(new Action(delegate
                    {
                        splitContainer1.Enabled = true;
                        stateLabel.Text = ofd.FileName;
                    }));
                });
            }
        }

        private static string IListToStr<T>(IList<T> li)
        {
            var sb = new StringBuilder("[");
            for (int i = 0; i < li.Count; i++)
            {
                if (i > 0)
                    sb.Append(", ");
                sb.Append(li[i]);
            }
            sb.Append(']');
            return sb.ToString();
        }
    }
}
