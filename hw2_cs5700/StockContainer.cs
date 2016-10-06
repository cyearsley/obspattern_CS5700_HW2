using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockSim;

namespace Panels
{
    public abstract class StockContainers : FlowLayoutPanel
    {
        public StockContainers()
        {
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "stockPanelContainer";
            this.Size = new System.Drawing.Size(880, 575);
            this.TabIndex = 0;
        }
    }

    public class StockContainer : StockContainers
    {
        //public 
    }

    public class StockPanel : Panel
    {
        public StockPanel()
        {
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point(13, 13);
            this.Name = "stockPanel";
            this.Size = new System.Drawing.Size(287, 278);
            this.TabIndex = 13;
        }
    }

}
