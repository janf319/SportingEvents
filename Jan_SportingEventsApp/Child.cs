using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_SportingEventsApp
{
    public partial class Child : Form1
    {
        private string city;
        private string name;
        private string sport;
        private string state;
        private string street;

        public string Name { get { return name; } }

        public string Sport { get { return sport;} }

        public Child() { }

        public Child(string childsName, string childsStreet, string childsCity, string childStates, string childSport) 
        {
            name = childsName;
            street = childsStreet;
            city = childsCity;
            state = childStates;
            sport = childSport;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(809, 605);
            this.Name = "Child";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
