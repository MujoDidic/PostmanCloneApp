namespace PostmanCloneUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ApiText = new TextBox();
            label2 = new Label();
            CallApi = new Button();
            ResultsJson = new TextBox();
            label3 = new Label();
            StatusResults = new StatusStrip();
            ResultsStatusLabel = new ToolStripStatusLabel();
            StatusResults.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Postmanclone";
            // 
            // ApiText
            // 
            ApiText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ApiText.Location = new Point(40, 128);
            ApiText.Name = "ApiText";
            ApiText.Size = new Size(692, 39);
            ApiText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 2;
            label2.Text = "URL";
            // 
            // CallApi
            // 
            CallApi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CallApi.Location = new Point(751, 127);
            CallApi.Name = "CallApi";
            CallApi.Size = new Size(75, 40);
            CallApi.TabIndex = 3;
            CallApi.Text = "GO";
            CallApi.UseVisualStyleBackColor = true;
            CallApi.Click += CallApi_Click;
            // 
            // ResultsJson
            // 
            ResultsJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultsJson.Location = new Point(40, 242);
            ResultsJson.Multiline = true;
            ResultsJson.Name = "ResultsJson";
            ResultsJson.ReadOnly = true;
            ResultsJson.ScrollBars = ScrollBars.Both;
            ResultsJson.Size = new Size(786, 289);
            ResultsJson.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 186);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 5;
            label3.Text = "Json Results";
            // 
            // StatusResults
            // 
            StatusResults.Items.AddRange(new ToolStripItem[] { ResultsStatusLabel });
            StatusResults.Location = new Point(0, 563);
            StatusResults.Name = "StatusResults";
            StatusResults.Size = new Size(854, 22);
            StatusResults.TabIndex = 6;
            StatusResults.Text = "statusStrip1";
            // 
            // ResultsStatusLabel
            // 
            ResultsStatusLabel.Name = "ResultsStatusLabel";
            ResultsStatusLabel.Size = new Size(39, 17);
            ResultsStatusLabel.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 585);
            Controls.Add(StatusResults);
            Controls.Add(label3);
            Controls.Add(ResultsJson);
            Controls.Add(CallApi);
            Controls.Add(label2);
            Controls.Add(ApiText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman with TC";
            StatusResults.ResumeLayout(false);
            StatusResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ApiText;
        private Label label2;
        private Button CallApi;
        private TextBox ResultsJson;
        private Label label3;
        private StatusStrip StatusResults;
        private ToolStripStatusLabel ResultsStatusLabel;
    }
}
