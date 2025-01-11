

//using OVASOFT.NET.EF.Onion.Abstractions.DomainModel;

//namespace OVASOFT.NET.EF.Onion.Examples.TestClasses;


//public class BarOneOne : IEntity<Guid>, IParent<Guid,Bar>
//{
//    public Guid Id { get; set; }
//    public Guid ParentId { get; set; }
//    public Bar Parent { get; set; }
//}

//public class BarManyMany : IEntity<Guid>, IChild<Bar>
//{
//    public Guid Id { get; set; }
//    public IList<Bar> Childs { get; set; }
//}

////public class BarAdditional: AEntityChild<Guid,Bar> //, IParent<Guid,Bar> 
////{
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
