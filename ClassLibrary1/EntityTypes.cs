using ClassLibrary1.EntityTypesTableAdapters;
using ClassLibrary1;

namespace ClassLibrary1
{
}

namespace ClassLibrary1
{
    public class EntitytypesM
    {
        public static EntityTypes.entitytypesDataTable GetEntitytypes() 
        { 
            return TANew().GetData();
        }
        public static entitytypesTableAdapter TANew()
        {
            return new entitytypesTableAdapter();
        }

    }
}

namespace ClassLibrary1.EntityTypesTableAdapters {
    
    
    public partial class entitytypesTableAdapter {
    }
}
