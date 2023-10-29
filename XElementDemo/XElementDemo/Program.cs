using System;
using System.Linq;
using System.Xml.Linq;

class XElementDemo {
    static void Main() {
        XElement category = new XElement(
            "menus",
            new XElement("Menu", "책"),
            new XElement("Menu", "강의"),
            new XElement("Menu", "컴퓨터")
        );
        Console.WriteLine(category);

        XElement newCategory = new XElement("Menus",
            from node in category.Elements()
            where node.Value.ToString().Length >= 2
            select node
        );
        Console.WriteLine(newCategory);
    }
}