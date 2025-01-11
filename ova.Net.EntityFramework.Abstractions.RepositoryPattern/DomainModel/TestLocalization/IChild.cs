
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;

namespace OVASOFT.NET.EF.Onion.Abstractions.DomainModel;


/// <summary>{0}</summary>
/// <typeparam name="TChild">{1}</typeparam>
public interface IChild2<TChild>
{
    /// <summary>{2}</summary>
    /// <value>{3}</value>
    IList<TChild> Childs { get; set; }
}


//   public interface IChild<TChild>
//{
//    /// <summary>Получает или предоставляет Childs как список сущностей.</summary>
//    /// <summary>{0}</summary>
//    /// <value>{1}</value>
//    IList<TChild> Childs { get; set; }
//}

public class ChildImplementation<TChild>: IChild<TChild>
{
    public IList<TChild> Childs { get; set; }

    public string GetDescription()
    {
        ResourceManager rm = new ResourceManager("OVASOFT.NET.EF.Onion.Abstractions.DomainModel.TestLocalization.Comments", typeof(ChildImplementation<>).Assembly);
        return rm.GetString("IChidsDescription", CultureInfo.CurrentCulture);
    }
}

/// <summary>{0}</summary>
/// <typeparam name="TChild">{1}</typeparam>
public interface IChild2<TChild>
{
    /// <summary>{2}</summary>
    /// <value>{3}</value>
    IList<TChild> Childs { get; set; }
}



/// <summary>
/// Say Hello to someone. 《-----------output to ${AssemblyName}.xml file.
/// </summary>
/// <summary lang="en-US">
/// Say Hello to somebody. 《-----------output to ${AssemblyName}.en-US.xml file.
/// </summary>
/// <summary lang="zh-CN">
/// 你好.(This is Chinese.) 《----------output to ${AssemblyName}.zh-CN.xml file.
/// </summary>
/// <summary lang="ja-JP">
/// こんにちは(This is Japanese) 《------------output to ${AssemblyName}.ja-JP.xml file.
/// </summary>
/// <param name="name">Person's name.</param> 《---------------output to ${AssemblyName}.xml file.
public static void Hello(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }