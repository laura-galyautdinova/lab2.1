namespace DzielenieApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDzielna;
        private System.Windows.Forms.TextBox textBoxDzielnik;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Button buttonDzielenie;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.textBoxDzielna = new System.Windows.Forms.TextBox();
            this.textBoxDzielnik = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.buttonDzielenie = new System.Windows.Forms.Button();

            // Initialize other properties and events for each control as needed
            this.textBoxDzielna.Location = new System.Drawing.Point(50, 30);
            this.textBoxDzielna.Name = "textBoxDzielna";
            this.textBoxDzielna.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.textBoxDzielna);

            this.textBoxDzielnik.Location = new System.Drawing.Point(50, 60);
            this.textBoxDzielnik.Name = "textBoxDzielnik";
            this.textBoxDzielnik.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.textBoxDzielnik);

            this.textBoxWynik.Location = new System.Drawing.Point(50, 120);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.ReadOnly = true;
            this.textBoxWynik.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(this.textBoxWynik);

            this.buttonDzielenie.Location = new System.Drawing.Point(50, 90);
            this.buttonDzielenie.Name = "buttonDzielenie";
            this.buttonDzielenie.Size = new System.Drawing.Size(100, 23);
            this.buttonDzielenie.Text = "Podziel";
            this.buttonDzielenie.Click += new System.EventHandler(this.buttonDzielenie_Click);
            this.Controls.Add(this.buttonDzielenie);
        }
    }
}
