using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar.Model
{
    internal class FoodModel
    {
        public FoodModel()
        {
            _name = "";
            _calories = 0;
            _protein = 0;
            _carbs = 0;
            _fat = 0;
            _fiber = 0;
        }

        public FoodModel(string name, int calories, int protein, int carbs, int fat, int fiber)
        {
            _name = name;
            _calories = calories;
            _protein = protein;
            _carbs = carbs;
            _fat = fat;
            _fiber = fiber;
        }
        // Remove this comment when done
        // Member order: public > internal > protected internal > protected > private; then static > non-static; then read-only > read-write
        #region ENUMS
        #endregion End Enums
        #region PROPERTIES
        private string _name {get; set; }
        private int _calories {get; set; }
        private int _protein {get; set; }
        private int _carbs {get; set; }
        private int _fat {get; set; }
        private int _fiber {get; set; }
        #endregion End Properties
        #region METHODS

        #endregion End Methods
        #region STRUCTS
        #endregion End Structs
        #region SUBCLASSES
        #endregion End Subclasses

    }
}
