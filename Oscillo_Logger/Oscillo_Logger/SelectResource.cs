using System.Windows.Forms;
using NationalInstruments.Visa;

namespace Oscillo_Logger
{
    /// <summary>
    /// Summary description for SelectResource.
    /// </summary>
    public class SelectResource : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ListBox availableResourcesListBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox visaResourceNameTextBox;
        private System.Windows.Forms.Label AvailableResourcesLabel;
        private System.Windows.Forms.Label ResourceStringLabel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public SelectResource()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectResource));
            this.availableResourcesListBox = new System.Windows.Forms.ListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.visaResourceNameTextBox = new System.Windows.Forms.TextBox();
            this.AvailableResourcesLabel = new System.Windows.Forms.Label();
            this.ResourceStringLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableResourcesListBox
            // 
            this.availableResourcesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableResourcesListBox.ItemHeight = 15;
            this.availableResourcesListBox.Location = new System.Drawing.Point(7, 21);
            this.availableResourcesListBox.Name = "availableResourcesListBox";
            this.availableResourcesListBox.Size = new System.Drawing.Size(278, 79);
            this.availableResourcesListBox.TabIndex = 0;
            this.availableResourcesListBox.SelectedIndexChanged += new System.EventHandler(this.availableResourcesListBox_SelectedIndexChanged);
            this.availableResourcesListBox.DoubleClick += new System.EventHandler(this.availableResourcesListBox_DoubleClick);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(7, 208);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(108, 29);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(115, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 29);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Cancel";
            // 
            // visaResourceNameTextBox
            // 
            this.visaResourceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visaResourceNameTextBox.Location = new System.Drawing.Point(7, 173);
            this.visaResourceNameTextBox.Name = "visaResourceNameTextBox";
            this.visaResourceNameTextBox.Size = new System.Drawing.Size(278, 22);
            this.visaResourceNameTextBox.TabIndex = 4;
            this.visaResourceNameTextBox.Text = "GPIB0::2::INSTR";
            // 
            // AvailableResourcesLabel
            // 
            this.AvailableResourcesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableResourcesLabel.Location = new System.Drawing.Point(7, 6);
            this.AvailableResourcesLabel.Name = "AvailableResourcesLabel";
            this.AvailableResourcesLabel.Size = new System.Drawing.Size(274, 14);
            this.AvailableResourcesLabel.TabIndex = 5;
            this.AvailableResourcesLabel.Text = "Available Resources:";
            // 
            // ResourceStringLabel
            // 
            this.ResourceStringLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResourceStringLabel.Location = new System.Drawing.Point(7, 155);
            this.ResourceStringLabel.Name = "ResourceStringLabel";
            this.ResourceStringLabel.Size = new System.Drawing.Size(274, 15);
            this.ResourceStringLabel.TabIndex = 6;
            this.ResourceStringLabel.Text = "Resource String:";
            // 
            // SelectResource
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(292, 246);
            this.Controls.Add(this.ResourceStringLabel);
            this.Controls.Add(this.AvailableResourcesLabel);
            this.Controls.Add(this.visaResourceNameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.availableResourcesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(248, 285);
            this.Name = "SelectResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Resource";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void OnLoad(object sender, System.EventArgs e)
        {
            // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
            // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
            // requires additional VISA .NET implementations.
            using (var rmSession = new ResourceManager())
            {
                var resources = rmSession.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string s in resources)
                {
                    availableResourcesListBox.Items.Add(s);
                }
            }
        }

        private void availableResourcesListBox_DoubleClick(object sender, System.EventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void availableResourcesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string selectedString = (string)availableResourcesListBox.SelectedItem;
            ResourceName = selectedString;
        }

        public string ResourceName
        {
            get
            {
                return visaResourceNameTextBox.Text;
            }
            set
            {
                visaResourceNameTextBox.Text = value;
            }
        }
    }
}
