using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athlete_Management
{
    public partial class StopwatchForm : Form
    {
        // Add these declarations at the class level
        private System.Diagnostics.Stopwatch stopwatch;
        private Timer timer;

        public StopwatchForm()
        {
            InitializeComponent();
            // Initialize the stopwatch and timer
            stopwatch = new System.Diagnostics.Stopwatch();
            timer = new Timer();
            timer.Interval = 10; // Update every 10 milliseconds
            timer.Tick += Timer_Tick;
        }

        // Rest of your code remains the same
        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            // Initialize the UI
            buttonStop.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the time display
            TimeSpan ts = stopwatch.Elapsed;
            labelTime.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Start the stopwatch and timer
            stopwatch.Start();
            timer.Start();
            // Update button states
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Stop the stopwatch and timer
            stopwatch.Stop();
            timer.Stop();
            // Update button states
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset the stopwatch
            stopwatch.Reset();
            // Update the display
            labelTime.Text = "00:00:00.00";
            // Update button states
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        public void ExportToCsv(List<ParticipantResult> data, string filePath, bool includeHeaders = true)
        {
            try
            {
                // Use a StringBuilder for efficient string concatenation
                StringBuilder sb = new StringBuilder();
                if (includeHeaders)
                {
                    // Append column headers
                    sb.AppendLine("BibNumber,Name,Team,FinishTime,Rank"); // Customize headers as needed
                }
                // Loop through the data and append each row to the StringBuilder
                foreach (var result in data)
                {
                    // Format each data row, handling commas and null values
                    sb.AppendLine($"{EscapeCsvField(result.BibNumber)}, {EscapeCsvField(result.Name)}, {EscapeCsvField(result.Team)},{EscapeCsvField(result.FinishTime.ToString())},{EscapeCsvField(result.Rank.ToString())}");
                }
                // Write the CSV data to the specified file
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Data exported to CSV successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., file access errors)
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Helper method to escape commas and quotes in CSV fields
        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return ""; // Or any other default value you prefer
            }
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                // Enclose the field in double quotes and escape any inner quotes
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }
            return field;
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            // Show the SaveFileDialog to let the user choose the file path
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialogCsv.FileName;
                // Get your race results data (replace with your actual data source)
                List<ParticipantResult> results = GetRaceResults(); // You need to implementthis method
            ExportToCsv(results, filePath);
            }
        }
        private List<ParticipantResult> GetRaceResults()
        {
            // Replace this with your actual logic to retrieve the race results
            // For example, you might get it from a DataGridView, a database query, or astored list.
List<ParticipantResult> results = new List<ParticipantResult>();
            // Add dummy data for demonstration
            results.Add(new ParticipantResult
            {
                BibNumber = "101",
                Name = "John Doe",
                Team
            = "Team A",
                FinishTime = TimeSpan.FromMinutes(20.5),
                Rank = 1
            });
            results.Add(new ParticipantResult
            {
                BibNumber = "102",
                Name = "Jane Smith",
                Team = "Team B",
                FinishTime = TimeSpan.FromMinutes(21.2),
                Rank = 2
            });
            results.Add(new ParticipantResult
            {
                BibNumber = "103",
                Name = "Peter Jones",
                Team = "Team A",
                FinishTime = TimeSpan.FromMinutes(22.1),
                Rank = 3
            });
            return results;
        }
    }

}