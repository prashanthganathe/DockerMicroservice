using DockerMicroservice.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMicroservice.Entities
{
    public static class SeedData
    {

        public static  List<ParentEntity>  ParentSeed()
        {
           return new List<ParentEntity>() {
                  new ParentEntity { Name = "Sydney" },
                  new ParentEntity { Name = "Brisbane" },
              };
        }

        //public static List<ChildEntity> ChildSeed()
        //{
        //    return new List<ChildEntity>() {
        //          new ChildEntity { Name = "SydneyChild1", Parent= new ParentEntity{ Id=1 } },
        //          new ChildEntity { Name = "BrisbaneChild2", Parent= new ParentEntity{ Id=2 } },
        //      };
        //}
    }
}
