using Arkadukt3.Addml;

namespace Arkadukt3
{
    class Project
    {
        private addml _addml;
        public addml Addml
        {
            get
            { return _addml != null ? _addml : (_addml = getAddml()); }
            set { _addml = value; }
        }

        public bool IsSaved { get; set; }

        public Project()
        {

        }

        private addml getAddml()
        {
            _addml = new addml();
            _addml.name = AddmlUtils.getUUID();

            _addml.dataset = new dataset[1];

            return _addml;
        }
    }
}