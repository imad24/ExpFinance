using System.Drawing;
using System.Windows.Forms;

namespace ExpFinance
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            var prompt = new Form
            {
                Width = 500,
                Height = 190,
                FormBorderStyle = FormBorderStyle.None,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Regular,GraphicsUnit.Point, ((0))),
                ForeColor = Color.DimGray
            };
            var textLabel = new Label { Left = 50, Top = 20, Text = text };
            var textBox = new TextBox { Left = 50, Top = 50, Width = 400, Height = 70,Multiline = true};
            var confirmation = new Button { Text = @"Ok", Left = 350, Width = 100, Top = 130, Height = 30,DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => prompt.Close();
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
