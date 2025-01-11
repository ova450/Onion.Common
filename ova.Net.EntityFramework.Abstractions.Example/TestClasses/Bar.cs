


using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;

//public class Bar: IEntity<Guid>, IParent<Guid, Foo>, IParent<Guid,BarOneOne>, IChild<BarManyMany>
//{

//    //public Foo Parent { get; set; }
//    //public BarAdditional Parent1 { get; set; }
//    //public Guid ParentId { get; set; }
//    //public Guid Id { get; set; }
//    ////public Guid ParentId { get; set; }
//    ////public Foo Parent1 { get; set; }
//    ////public BarAdditional Parent2 { get; set; }
//    ////////public Guid ParentId { get; set; }
//    ////////public BarAdditional Parent { get; set; }
//    //////public Guid ParentId { get; set; }
//    //////Foo IParent<Guid, Foo>.Parent { get; set; }
//    //////BarAdditional IParent<Guid, BarAdditional>.Parent { get; set; }

//    //public Foo foo
//    //{
//    //    get => (Foo) ((IParent<Guid, Foo>) this).Parent;
//    //    set => ((IParent<Guid, Foo>) this).Parent = value;
//    //}

//    //public BarAdditional baradd
//    //{
//    //    get => (BarAdditional) ((IParent<Guid, BarAdditional>) this).Parent;
//    //    set => ((IParent<Guid, BarAdditional>) this).Parent = value;
//    //}





//    //public Guid ParentId { get; set; }
//    //public Foo Parent { get; set; }
//    //BarAdditional IParent<Guid, BarAdditional>.Parent { get; set; }
//    //BarAdditional IParent<Guid, BarAdditional>.Parent { get; set; }
//    //BarAdditional IParent<Guid, BarAdditional>.Parent { get; set; }
//    ////BarAdditional IParent<Guid, BarAdditional>.Parent { get; set; }
//    //////public IList<BarAdditional> Childs { get; set; }
//}

////public class BarAdditional: IParent<Guid,Bar> 
////{
////    public Guid ParentId { get; set; }
////    public Bar Parent { get; set; }
////    public Guid Id { get; set; }
////    //public Guid ParentId { get; set; }
////    //public Bar Parent { get; set; }


////    //Guid IParent<Guid, Bar>.ParentId { get; set; }
////    //Bar IParent<Guid, Bar>.Parent { get; set; }

////    // Внешний ключ для связи с Bar
////    //public Guid BarId
////    //{
////    //    get => ((IParent<Guid, Bar>) this).ParentId;
////    //    set => ((IParent<Guid, Bar>) this).ParentId = value;
////    //}

////    //public Bar Bar
////    //{
////    //    get => (Bar) ((IParent<Guid, Bar>) this).Parent;
////    //    set => ((IParent<Guid, Bar>) this).Parent = value;
////    //}

////}
