using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToolShed.Models;
using System.ComponentModel.DataAnnotations;

namespace ToolShed.Models{
    public class Tool : Items {
        [Display(Name = "Brand")]
        public String brand { get; set; }  // brand of tool
        [Display(Name = "Toolbox")]
        public String toolbox { get; set; }  // name of possible toolbox
        [Display(Name = "Does it have a toolbox?")]
        public bool hasToolbox { get; set; }    //should the tool be in a toolbox

        public Tool() {

        }

        /*
         * constructor for a new tool
         * @param String Name of the tool,boolean inToolbox,int sku of the tool,
	     * float Price of the tool, String Brand of the tool,int AcqDate the acquisition date of the tool
         */
        public Tool(String Name, bool inToolbox, int sku, float Price, String Brand, DateTime AcqDate) {
            //setName(Name);
            //setToolboxStatus(inToolbox);
            //setSKU(sku);
            //setPrice(Price);
            //setBrand(Brand);
            //setAcqDate(AcqDate);

        }

        /*
         * returns the Brand of the tool
         */
        public String getBrand() {
            return this.brand;
        }

        /*
         * @param args Name = brand of new tool
         * sets the brand of the tool
         */
        public void setBrand(String Name) {
            this.brand = Name;
        }

        /*
         * returns the name of the toolbox
         */
        public String getToolbox() {
            return this.toolbox;
        }

        /*
         * @param args Name = name of new toolbox
         * sets the name of the toolbox
         */
        public void setToolbox(String Name) {
            this.toolbox = Name;
        }

        /*
         * returns if the tool belongs in a toolbox
         */
        public bool getToolboxStatus() {
            return this.hasToolbox;
        }

        /*
         * @param args status = does the new tool belong in a toolbox
         * sets if the tool belongs in a toolbox
         */
        public void setToolboxStatus(bool status) {
            this.hasToolbox = status;
        }

    }
}
