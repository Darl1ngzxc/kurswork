namespace Kurssss
{
    partial class FormKnapsack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            groupBoxTools = new GroupBox();
            button1 = new Button();
            buttonAddItem = new Button();
            buttonSetCapacity = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBoxTools.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox.Location = new Point(1, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(735, 592);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(button1);
            groupBoxTools.Controls.Add(buttonAddItem);
            groupBoxTools.Controls.Add(buttonSetCapacity);
            groupBoxTools.Location = new Point(742, 0);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new Size(200, 592);
            groupBoxTools.TabIndex = 1;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Инструменты";
            // 
            // button1
            // 
            button1.Location = new Point(6, 180);
            button1.Name = "button1";
            button1.Size = new Size(188, 40);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Enabled = false;
            buttonAddItem.Location = new Point(6, 134);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(188, 40);
            buttonAddItem.TabIndex = 1;
            buttonAddItem.Text = "Добавить предмет";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonSetCapacity
            // 
            buttonSetCapacity.Location = new Point(6, 22);
            buttonSetCapacity.Name = "buttonSetCapacity";
            buttonSetCapacity.Size = new Size(188, 34);
            buttonSetCapacity.TabIndex = 0;
            buttonSetCapacity.Text = "Задать вместимость рюкзака";
            buttonSetCapacity.UseVisualStyleBackColor = true;
            buttonSetCapacity.Click += buttonSetCapacity_Click;
            // 
            // FormKnapsack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 594);
            Controls.Add(groupBoxTools);
            Controls.Add(pictureBox);
            Name = "FormKnapsack";
            Text = "FormKnapsack";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBoxTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupBoxTools;
        private Button buttonSetCapacity;
        private Button button1;
        private Button buttonAddItem;
    }
}