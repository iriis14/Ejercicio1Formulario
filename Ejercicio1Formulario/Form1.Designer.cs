namespace Ejercicio1Formulario
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblCriticity = new System.Windows.Forms.Label();
            this.cbCriticy = new System.Windows.Forms.ComboBox();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.CheckBox();
            this.cbPreprod = new System.Windows.Forms.CheckBox();
            this.cbDemo = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSartDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuation = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cbPercent = new System.Windows.Forms.ComboBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSumbit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(31, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(34, 55);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(215, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(288, 35);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Barcelona",
            "Madrid"});
            this.cbLocation.Location = new System.Drawing.Point(291, 53);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(221, 24);
            this.cbLocation.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(34, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Incident",
            "No Incident",
            "Etc"});
            this.cbType.Location = new System.Drawing.Point(37, 128);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(124, 24);
            this.cbType.TabIndex = 5;
            // 
            // lblCriticity
            // 
            this.lblCriticity.AutoSize = true;
            this.lblCriticity.Location = new System.Drawing.Point(191, 109);
            this.lblCriticity.Name = "lblCriticity";
            this.lblCriticity.Size = new System.Drawing.Size(49, 16);
            this.lblCriticity.TabIndex = 6;
            this.lblCriticity.Text = "Criticity";
            // 
            // cbCriticy
            // 
            this.cbCriticy.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCriticy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriticy.FormattingEnabled = true;
            this.cbCriticy.Items.AddRange(new object[] {
            "Minor",
            "Major",
            "Extreme"});
            this.cbCriticy.Location = new System.Drawing.Point(194, 128);
            this.cbCriticy.Name = "cbCriticy";
            this.cbCriticy.Size = new System.Drawing.Size(124, 24);
            this.cbCriticy.TabIndex = 7;
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Location = new System.Drawing.Point(350, 109);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(81, 16);
            this.lblEnvironment.TabIndex = 8;
            this.lblEnvironment.Text = "Environment";
            // 
            // cbProd
            // 
            this.cbProd.AutoSize = true;
            this.cbProd.Location = new System.Drawing.Point(353, 131);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(58, 20);
            this.cbProd.TabIndex = 9;
            this.cbProd.Text = "Prod";
            this.cbProd.UseVisualStyleBackColor = true;
            // 
            // cbPreprod
            // 
            this.cbPreprod.AutoSize = true;
            this.cbPreprod.Location = new System.Drawing.Point(353, 157);
            this.cbPreprod.Name = "cbPreprod";
            this.cbPreprod.Size = new System.Drawing.Size(78, 20);
            this.cbPreprod.TabIndex = 10;
            this.cbPreprod.Text = "Preprod";
            this.cbPreprod.UseVisualStyleBackColor = true;
            // 
            // cbDemo
            // 
            this.cbDemo.AutoSize = true;
            this.cbDemo.Location = new System.Drawing.Point(353, 183);
            this.cbDemo.Name = "cbDemo";
            this.cbDemo.Size = new System.Drawing.Size(66, 20);
            this.cbDemo.TabIndex = 11;
            this.cbDemo.Text = "Demo";
            this.cbDemo.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(34, 227);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(34, 246);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(478, 153);
            this.txtDescription.TabIndex = 13;
            // 
            // lblSartDate
            // 
            this.lblSartDate.AutoSize = true;
            this.lblSartDate.Location = new System.Drawing.Point(34, 427);
            this.lblSartDate.Name = "lblSartDate";
            this.lblSartDate.Size = new System.Drawing.Size(66, 16);
            this.lblSartDate.TabIndex = 14;
            this.lblSartDate.Text = "Start Date";
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(34, 446);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(127, 22);
            this.datePicker.TabIndex = 15;
            this.datePicker.Value = new System.DateTime(2024, 10, 23, 10, 22, 45, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(291, 426);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(114, 16);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // numDuation
            // 
            this.numDuation.DecimalPlaces = 2;
            this.numDuation.Location = new System.Drawing.Point(294, 446);
            this.numDuation.Name = "numDuation";
            this.numDuation.Size = new System.Drawing.Size(120, 22);
            this.numDuation.TabIndex = 17;
            this.numDuation.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(34, 496);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Planned",
            "Pendent",
            "Doing",
            "Done"});
            this.cbStatus.Location = new System.Drawing.Point(37, 515);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 24);
            this.cbStatus.TabIndex = 19;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(294, 496);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(114, 16);
            this.lblPercent.TabIndex = 20;
            this.lblPercent.Text = "Percent Complete";
            // 
            // cbPercent
            // 
            this.cbPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPercent.FormattingEnabled = true;
            this.cbPercent.Items.AddRange(new object[] {
            "0%",
            "15%",
            "35%",
            "50%",
            "70%",
            "85%",
            "99%",
            "100%"});
            this.cbPercent.Location = new System.Drawing.Point(294, 515);
            this.cbPercent.Name = "cbPercent";
            this.cbPercent.Size = new System.Drawing.Size(120, 24);
            this.cbPercent.TabIndex = 21;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(37, 568);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(262, 20);
            this.cbEmail.TabIndex = 22;
            this.cbEmail.Text = "Check here if you want to send an email";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(344, 651);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 23;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSumbit
            // 
            this.bSumbit.Location = new System.Drawing.Point(437, 651);
            this.bSumbit.Name = "bSumbit";
            this.bSumbit.Size = new System.Drawing.Size(75, 23);
            this.bSumbit.TabIndex = 24;
            this.bSumbit.Text = "Sumbit";
            this.bSumbit.UseVisualStyleBackColor = true;
            this.bSumbit.Click += new System.EventHandler(this.bSumbit_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 706);
            this.Controls.Add(this.bSumbit);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.cbEmail);
            this.Controls.Add(this.cbPercent);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.numDuation);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblSartDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cbDemo);
            this.Controls.Add(this.cbPreprod);
            this.Controls.Add(this.cbProd);
            this.Controls.Add(this.lblEnvironment);
            this.Controls.Add(this.cbCriticy);
            this.Controls.Add(this.lblCriticity);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "VentanaPrincipal";
            this.Text = "Create New Task";
            ((System.ComponentModel.ISupportInitialize)(this.numDuation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblCriticity;
        private System.Windows.Forms.ComboBox cbCriticy;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.CheckBox cbProd;
        private System.Windows.Forms.CheckBox cbPreprod;
        private System.Windows.Forms.CheckBox cbDemo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSartDate;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox cbPercent;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSumbit;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}

