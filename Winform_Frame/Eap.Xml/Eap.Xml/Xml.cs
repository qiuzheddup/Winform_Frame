using System.Xml;
using System.Collections.Generic;

using Eap.Entity;

namespace Eap
{
    public class Xml
    {
        private XmlDocument xml = new XmlDocument();
        private string strFileName;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filename">Xml文件名</param>
        public Xml(string filename)
        {
            strFileName = filename;
            xml.Load(filename);
        }

        /// <summary>
        /// 保存Xml文件
        /// </summary>
        /// <returns>true：成功；false：失败</returns>
        private bool Save()
        {
            try
            {
                xml.Save(strFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="node">要添加的节点名称</param>
        /// <param name="innertext">节点文本内容（可以为空）</param>
        /// <returns>true：成功；false：失败</returns>
        public bool AddNode(string xpath, string node, string innertext)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);

                XmlElement xelem = xml.CreateElement(node);
                xelem.InnerText = innertext;

                xnode.AppendChild(xelem);
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 给节点添加属性
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="attr">属性名称</param>
        /// <param name="value">属性值</param>
        public bool AddAttribute(string xpath, string attr, string value)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);

                XmlAttribute xattr = xml.CreateAttribute(attr);
                xattr.Value = value;

                xnode.Attributes.Append(xattr);
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改节点的值
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="innertext">修改后的值</param>
        /// <returns>true：成功；false：失败</returns>
        public bool EditNode(string xpath, string innertext)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);
                xnode.InnerText = innertext;
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 修改属性的值
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="attr">属性名称</param>
        /// <param name="value">修改后的属性值</param>
        /// <returns>true：成功；false：失败</returns>
        public bool EditAttribute(string xpath, string attr, string value)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);

                XmlAttribute xattr = xml.CreateAttribute(attr);
                xattr.Value = value;

                xnode.Attributes.SetNamedItem(xattr);
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <returns>ture：成功；false：失败</returns>
        public bool DelNode(string xpath)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);
                XmlNode xparent = xnode.ParentNode;
                xparent.RemoveChild(xnode);
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除属性
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="attr">属性名称</param>
        /// <returns>true：成功；false：失败</returns>
        public bool DelAttribute(string xpath, string attr)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);
                XmlAttributeCollection xattrs = xnode.Attributes;

                xnode.Attributes.Remove(xattrs[attr]);
                return Save();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取节点的值
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <returns>节点的值</returns>
        public string GetNodeValue(string xpath)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);
                return xnode.InnerText;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取属性的值
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <param name="attr">属性名称</param>
        /// <returns>属性的值</returns>
        public string GetAttributeValue(string xpath, string attr)
        {
            try
            {
                XmlNode xnode = xml.SelectSingleNode(xpath);
                XmlAttributeCollection xattrs = xnode.Attributes;
                return xattrs[attr].InnerText;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取节点的子节点
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <returns>子节点集</returns>
        public List<EapItem> GetNodes(string xpath)
        {
            try
            {
                XmlNodeList xlist = xml.SelectSingleNode(xpath).ChildNodes;
                List<EapItem> list = new List<EapItem>();

                foreach (XmlNode xnode in xlist)
                {
                    list.Add(new EapItem(xnode.Name, xnode.InnerText));
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取节点的属性集合
        /// </summary>
        /// <param name="xpath">节点路径</param>
        /// <returns>节点的属性集</returns>
        public List<EapItem> GetAttributes(string xpath)
        {
            try
            {
                XmlAttributeCollection xattrs = xml.SelectSingleNode(xpath).Attributes;
                List<EapItem> list = new List<EapItem>();

                foreach (XmlAttribute xattr in xattrs)
                {
                    list.Add(new EapItem(xattr.Name, xattr.InnerText));
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
