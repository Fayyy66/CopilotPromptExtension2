using System;
using System.Drawing;
using System.Windows.Forms;

namespace CopilotPromptExtension2
{
    internal sealed class PromptInputForm : Form
    {
        private readonly TextBox targetFeatureTextBox;
        private readonly TextBox sourceFeatureTextBox;
        private readonly TextBox requirementTextBox;

        public PromptInputForm()
        {
            Text = "Generate Copilot Scaffold Prompt";
            Width = 720;
            Height = 560;
            StartPosition = FormStartPosition.CenterParent;
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 7,
                Padding = new Padding(12)
            };

            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            targetFeatureTextBox = CreateSingleLineTextBox("NewFeature");
            sourceFeatureTextBox = CreateSingleLineTextBox("ExistingFeature");
            requirementTextBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                AcceptsReturn = true,
                AcceptsTab = true,
                Font = new Font(FontFamily.GenericSansSerif, 9),
                Text = "Paste the technical requirement document or feature summary here."
            };

            root.Controls.Add(CreateLabel("Target feature"), 0, 0);
            root.Controls.Add(targetFeatureTextBox, 0, 1);
            root.Controls.Add(CreateLabel("Reference feature"), 0, 2);
            root.Controls.Add(sourceFeatureTextBox, 0, 3);
            root.Controls.Add(CreateLabel("Technical requirement"), 0, 4);
            root.Controls.Add(requirementTextBox, 0, 5);
            root.Controls.Add(CreateButtonPanel(), 0, 6);

            Controls.Add(root);
        }

        public DomainScaffoldingRequest Request
        {
            get
            {
                return new DomainScaffoldingRequest
                {
                    TargetFeatureName = targetFeatureTextBox.Text,
                    SourceFeatureName = sourceFeatureTextBox.Text,
                    TechnicalRequirement = requirementTextBox.Text
                };
            }
        }

        private static Label CreateLabel(string text)
        {
            return new Label
            {
                AutoSize = true,
                Margin = new Padding(0, 6, 0, 4),
                Text = text
            };
        }

        private static TextBox CreateSingleLineTextBox(string value)
        {
            return new TextBox
            {
                Dock = DockStyle.Top,
                Text = value
            };
        }

        private FlowLayoutPanel CreateButtonPanel()
        {
            var generateButton = new Button
            {
                DialogResult = DialogResult.OK,
                Text = "Generate",
                Width = 96
            };

            var cancelButton = new Button
            {
                DialogResult = DialogResult.Cancel,
                Text = "Cancel",
                Width = 96
            };

            AcceptButton = generateButton;
            CancelButton = cancelButton;

            var panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(0, 12, 0, 0),
                AutoSize = true
            };

            panel.Controls.Add(generateButton);
            panel.Controls.Add(cancelButton);
            return panel;
        }
    }
}
