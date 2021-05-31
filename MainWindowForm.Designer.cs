
namespace MapApp
{
    partial class MainWindowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonDBClient = new System.Windows.Forms.Button();
            this.buttonDBWorkers = new System.Windows.Forms.Button();
            this.buttonUserCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя пользователя:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(121, 9);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(0, 13);
            this.labelType.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(124, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(210, 517);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(128, 29);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход из аккаунта";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(15, 76);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(323, 49);
            this.buttonMap.TabIndex = 6;
            this.buttonMap.Text = "Создать карту";
            this.buttonMap.UseVisualStyleBackColor = true;
            // 
            // buttonDBClient
            // 
            this.buttonDBClient.Location = new System.Drawing.Point(15, 131);
            this.buttonDBClient.Name = "buttonDBClient";
            this.buttonDBClient.Size = new System.Drawing.Size(323, 49);
            this.buttonDBClient.TabIndex = 7;
            this.buttonDBClient.Text = "Просмотр БД клиентов";
            this.buttonDBClient.UseVisualStyleBackColor = true;
            // 
            // buttonDBWorkers
            // 
            this.buttonDBWorkers.Location = new System.Drawing.Point(15, 186);
            this.buttonDBWorkers.Name = "buttonDBWorkers";
            this.buttonDBWorkers.Size = new System.Drawing.Size(323, 49);
            this.buttonDBWorkers.TabIndex = 8;
            this.buttonDBWorkers.Text = "Просмотр БД пользователей";
            this.buttonDBWorkers.UseVisualStyleBackColor = true;
            this.buttonDBWorkers.Click += new System.EventHandler(this.buttonDBWorkers_Click);
            // 
            // buttonUserCreate
            // 
            this.buttonUserCreate.Location = new System.Drawing.Point(15, 241);
            this.buttonUserCreate.Name = "buttonUserCreate";
            this.buttonUserCreate.Size = new System.Drawing.Size(323, 49);
            this.buttonUserCreate.TabIndex = 9;
            this.buttonUserCreate.Text = "Создать пользователя";
            this.buttonUserCreate.UseVisualStyleBackColor = true;
            this.buttonUserCreate.Click += new System.EventHandler(this.buttonUserCreate_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 568);
            this.Controls.Add(this.buttonUserCreate);
            this.Controls.Add(this.buttonDBWorkers);
            this.Controls.Add(this.buttonDBClient);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Text = "Главное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonDBClient;
        private System.Windows.Forms.Button buttonDBWorkers;
        private System.Windows.Forms.Button buttonUserCreate;
    }
}