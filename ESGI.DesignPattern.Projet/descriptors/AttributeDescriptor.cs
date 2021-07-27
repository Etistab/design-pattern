using System;

namespace ESGI.DesignPattern.Projet
{
    public abstract class AttributeDescriptor
    {
        private readonly string descriptorName;
        private readonly Type mapperType;
        private readonly Type forType;

        private AttributeDescriptor()
        {}

        public static AttributeDescriptor Create(string config, string descriptorName, Type mapperType, Type forType)
        {
            switch(config)
            {
                case "boolean":
                    return new BooleanDescriptor(descriptorName, mapperType, forType);
                case "reference":
                    return new ReferenceDescriptor(descriptorName, mapperType, forType);
                case "default":
                    return new DefaultDescriptor(descriptorName, mapperType, forType);
                default:
                    throw new Exception("unknown config");
            }
        }

        protected AttributeDescriptor(string descriptorName, Type mapperType, Type forType)
        {
            this.descriptorName = descriptorName;
            this.mapperType = mapperType;
            this.forType = forType;
        }

        public string DescriptorName => descriptorName;
    }
}