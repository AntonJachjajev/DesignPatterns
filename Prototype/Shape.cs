using System;

namespace DesignPatterns.Prototype
{
    public abstract class Shape : ICloneable
    {
        private string _id;
        protected string Type;

        public abstract void Draw();

        public new string GetType()
        {
            return Type;
        }

        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            this._id = id;
        }

        public object Clone()
        {
            object clone = null;

            try
            {
                clone = MemberwiseClone();

            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }

            return clone;
        }
    }
}
