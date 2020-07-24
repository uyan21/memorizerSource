using System.Windows.Forms;

namespace formdb
{
    partial class win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.examTab = new System.Windows.Forms.TabPage();
            this.qnumber = new System.Windows.Forms.Label();
            this.deter = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.addTab = new System.Windows.Forms.TabPage();
            this.dbName = new System.Windows.Forms.TextBox();
            this.addDb = new System.Windows.Forms.Button();
            this.addA = new System.Windows.Forms.TextBox();
            this.addQ = new System.Windows.Forms.TextBox();
            this.addField = new System.Windows.Forms.Button();
            this.dbList = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.examTab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.examTab);
            this.tabControl1.Controls.Add(this.addTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 395);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // examTab
            // 
            this.examTab.Controls.Add(this.qnumber);
            this.examTab.Controls.Add(this.deter);
            this.examTab.Controls.Add(this.question);
            this.examTab.Controls.Add(this.answer);
            this.examTab.Location = new System.Drawing.Point(4, 29);
            this.examTab.Name = "examTab";
            this.examTab.Padding = new System.Windows.Forms.Padding(3);
            this.examTab.Size = new System.Drawing.Size(768, 362);
            this.examTab.TabIndex = 0;
            this.examTab.Text = "Exam";
            this.examTab.UseVisualStyleBackColor = true;
            // 
            // qnumber
            // 
            this.qnumber.AutoSize = true;
            this.qnumber.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qnumber.Location = new System.Drawing.Point(468, 75);
            this.qnumber.Name = "qnumber";
            this.qnumber.Size = new System.Drawing.Size(0, 28);
            this.qnumber.TabIndex = 3;
            // 
            // deter
            // 
            this.deter.AutoSize = true;
            this.deter.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deter.Location = new System.Drawing.Point(524, 172);
            this.deter.Name = "deter";
            this.deter.Size = new System.Drawing.Size(0, 31);
            this.deter.TabIndex = 2;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(14, 82);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(21, 20);
            this.question.TabIndex = 1;
            this.question.Text = "Q";
            // 
            // answer
            // 
            this.answer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answer.Location = new System.Drawing.Point(14, 216);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(317, 38);
            this.answer.TabIndex = 0;
            this.answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answer_KeyPress);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.dbName);
            this.addTab.Controls.Add(this.addDb);
            this.addTab.Controls.Add(this.addA);
            this.addTab.Controls.Add(this.addQ);
            this.addTab.Controls.Add(this.addField);
            this.addTab.Location = new System.Drawing.Point(4, 29);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(768, 362);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(10, 10);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(125, 27);
            this.dbName.TabIndex = 2;
            // 
            // addDb
            // 
            this.addDb.Location = new System.Drawing.Point(150, 10);
            this.addDb.Name = "addDb";
            this.addDb.Size = new System.Drawing.Size(94, 29);
            this.addDb.TabIndex = 2;
            this.addDb.Text = "DB추가";
            this.addDb.UseVisualStyleBackColor = true;
            this.addDb.Click += new System.EventHandler(this.dbAdd);
            // 
            // addA
            // 
            this.addA.Location = new System.Drawing.Point(14, 216);
            this.addA.Name = "addA";
            this.addA.Size = new System.Drawing.Size(300, 27);
            this.addA.TabIndex = 3;
            this.addA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eInsert_field);
            // 
            // addQ
            // 
            this.addQ.Location = new System.Drawing.Point(14, 97);
            this.addQ.Multiline = true;
            this.addQ.Name = "addQ";
            this.addQ.Size = new System.Drawing.Size(300, 113);
            this.addQ.TabIndex = 2;
            // 
            // addField
            // 
            this.addField.Location = new System.Drawing.Point(14, 273);
            this.addField.Name = "addField";
            this.addField.Size = new System.Drawing.Size(94, 29);
            this.addField.TabIndex = 4;
            this.addField.Text = "추가";
            this.addField.UseVisualStyleBackColor = true;
            this.addField.Click += new System.EventHandler(this.insert_field);
            // 
            // dbList
            // 
            this.dbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(500, 20);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(151, 28);
            this.dbList.TabIndex = 1;
            this.dbList.SelectedIndexChanged += new System.EventHandler(this.listChanged);
            // 
            // win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbList);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "win";
            this.Text = "Memorizer";
            this.Load += new System.EventHandler(this.win_Load);
            this.tabControl1.ResumeLayout(false);
            this.examTab.ResumeLayout(false);
            this.examTab.PerformLayout();
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage examTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label question;
        private TextBox dbName;
        private Button addDb;
        private ComboBox dbList;
        private TextBox addA;
        private TextBox addQ;
        private Button addField;
        private Label deter;
        private Label qnumber;
    }
}

