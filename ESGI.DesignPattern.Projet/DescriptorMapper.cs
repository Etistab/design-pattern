using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class DescriptorMapper
    {
        protected List<AttributeDescriptor> CreateAttributeDescriptors() {
            var result = new List<AttributeDescriptor>();

            result.Add(
                AttributeDescriptor.create("default", "remoteId", GetClass(), typeof(int))
            );
            result.Add(
                AttributeDescriptor.create("default", "createdDate", GetClass(), typeof(DateTime))
            );
            result.Add(
                AttributeDescriptor.create("default", "lastChangedDate", GetClass(), typeof(DateTime))
            );
            result.Add(
                AttributeDescriptor.create("reference", "createdBy", GetClass(), typeof(User))
            );
            result.Add(
                AttributeDescriptor.create("reference", "lastChangedBy", GetClass(), typeof(User))
            );
            result.Add(
                AttributeDescriptor.create("default", "optimisticLockVersion", GetClass(), typeof(int))
            );

            return result;
        }

        private Type GetClass()
        {
            return typeof(DescriptorMapper);
        }
    }
}