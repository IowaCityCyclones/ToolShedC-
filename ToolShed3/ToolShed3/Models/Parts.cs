using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolShed.Models{
    class Parts:Items{
        int quantity; // how many of the parts should be there
        Types type; // type of the part

        public enum Types { Bolt, Nut, Nail, Screw, Part }

        /*
         * constructor for a part with a specfic type
         * @param String Name of the part,int sku of the part,
	     * float Price of the part, int quantity of the part, int AcqDate the acquisition date of the part
         */
        public Parts(String Name, int sku, float Price, int quantity, DateTime AcqDate) {
            //setName(Name);
            setSKU(sku);
            setPrice(Price);
            setAcqDate(AcqDate);
            setType(Types.Part);
        }

        /*
         * constructor for a generic part
         * @param String Name of the part,int sku of the part, type is the type of the part,
	     * float Price of the part, int quantity of the part,int AcqDate the acquisition date of the part
         */
        public Parts(String Name, int sku, float Price, int quantity, DateTime AcqDate, Types type) : this(Name, sku, Price, quantity, AcqDate) {
            setType(type);
        }

        /*
         * returns the type of the part
         */
        public Types getType() {
            return type;
        }

        /*
         * @param args t = type of new parts
         * sets the type of the new part
         */
        public void setType(Types t) {
            this.type = t;
        }

        /*
         * returns the quantity of the part
         */
        public int getQuantity() {
            return quantity;
        }

        /*
         * @param args amount = quantity of new parts
         * sets the quantity of the new part
         */
        public void setQuantity(int amount) {
            this.quantity = amount;
        }

        /*
         * adds one to the quantity
         */
        public void addPart() {
            quantity++;
        }

        /*
         * @param args amount = number to add of new parts
         * adds amount to the quantity
         */
        public void addPart(int amount) {
            quantity =+ amount;
        }

        /*
        * adds one to the quantity
        */
        public void subtractPart() {
            if(quantity >= 1) {
                quantity--;
            }
            else {
                // should return error message
            }
        }

        /*
         * @param args amount = number to subtract of new parts if leaves a negative quantity error
         * subtracts amount to the quantity
         */
        public void subtractPart(int amount) {
            int save = quantity;

            quantity = amount;
            if (quantity < 0) {
                // should return error message
                quantity = save;
            }
            else {
                // should return success message
            }
        }

    }

    /*
     * constructor for a screw
     * @param String Name of the part,int sku of the part,
	 * float Price of the part, int quantity of the part, int AcqDate the acquisition date of the part
     */
    class Screws :Parts {
        public Screws(String Name, int sku, float Price, int quantity, DateTime AcqDate):base(Name, sku, Price, quantity, AcqDate) {
            this.setType(Types.Screw);
        }
    }

    /*
     * constructor for a bolt
     * @param String Name of the part,int sku of the part,
	 * float Price of the part, int quantity of the part, int AcqDate the acquisition date of the part
     */
    class Bolts : Parts {
        public Bolts(String Name, int sku, float Price, int quantity, DateTime AcqDate) : base(Name, sku, Price, quantity, AcqDate) {
            this.setType(Types.Bolt);
        }
    }

    /*
     * constructor for a snut
     * @param String Name of the part,int sku of the part,
	 * float Price of the part, int quantity of the part, int AcqDate the acquisition date of the part
     */
    class Nuts : Parts {
        public Nuts(String Name, int sku, float Price, int quantity, DateTime AcqDate) : base(Name, sku, Price, quantity, AcqDate) {
            this.setType(Types.Nut);
        }
    }

    /*
     * constructor for a nail
     * @param String Name of the part,int sku of the part,
	 * float Price of the part, int quantity of the part, int AcqDate the acquisition date of the part
     */
    class Nails : Parts {
        public Nails(String Name, int sku, float Price, int quantity, DateTime AcqDate) : base(Name, sku, Price, quantity, AcqDate) {
            this.setType(Types.Nail);
        }
    }
}
