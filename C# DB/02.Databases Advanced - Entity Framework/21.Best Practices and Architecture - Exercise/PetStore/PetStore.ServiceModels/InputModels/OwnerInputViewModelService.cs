using System.Collections.Generic;

namespace PetStore.ServiceModels.InputModels
{
    public class OwnerInputViewModelService
    {
        public string Name { get; set; }

        public List<string> Pets { get; set; }
    }
}
