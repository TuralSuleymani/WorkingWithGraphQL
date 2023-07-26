namespace GraphQLSchemaFirstApproach
{
    partial class MainForm
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
            rcbx_request = new RichTextBox();
            label1 = new Label();
            rcbx_response = new RichTextBox();
            label2 = new Label();
            btn_execute = new Button();
            SuspendLayout();
            // 
            // rcbx_request
            // 
            rcbx_request.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rcbx_request.Location = new Point(21, 39);
            rcbx_request.Name = "rcbx_request";
            rcbx_request.Size = new Size(381, 405);
            rcbx_request.TabIndex = 0;
            rcbx_request.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "GraphQL query : ";
            // 
            // rcbx_response
            // 
            rcbx_response.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rcbx_response.Location = new Point(594, 39);
            rcbx_response.Name = "rcbx_response";
            rcbx_response.Size = new Size(428, 403);
            rcbx_response.TabIndex = 2;
            rcbx_response.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 17);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 3;
            label2.Text = "GraphQL response:";
            // 
            // btn_execute
            // 
            btn_execute.Location = new Point(439, 191);
            btn_execute.Name = "btn_execute";
            btn_execute.Size = new Size(134, 36);
            btn_execute.TabIndex = 4;
            btn_execute.Text = "Execute ->";
            btn_execute.UseVisualStyleBackColor = true;
            btn_execute.Click += Btn_execute_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 472);
            Controls.Add(btn_execute);
            Controls.Add(label2);
            Controls.Add(rcbx_response);
            Controls.Add(label1);
            Controls.Add(rcbx_request);
            Name = "MainForm";
            Text = "GraphQL Schema First Approach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rcbx_request;
        private Label label1;
        private RichTextBox rcbx_response;
        private Label label2;
        private Button btn_execute;
    }
}