using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using OfficeOpenXml;
using OfficeOpenXml.Table;
using System.Reflection;

namespace Eap
{
    public class ExcelOpenXml
    {

        public static string ExportSpreadsheet<T>(byte[] source, string destfilename, Dictionary<string, string> TitleKeyValue, List<T> list_data)
        {
            try
            {

                //复制模版文件
                File.WriteAllBytes(destfilename, source);
                FileInfo template = new FileInfo(destfilename);

                using (ExcelPackage package = new ExcelPackage(template))
                {
                    ExcelWorksheets worksheets = package.Workbook.Worksheets;

                    foreach (var worksheet in worksheets)
                    {
                        Dictionary<string, string> dictHeader = new Dictionary<string, string>();//<"A1","$F$Title">
                        Dictionary<int, string> dictRows = new Dictionary<int, string>();//<"A1","F$Field">

                        //空表
                        if (worksheet.Dimension == null)
                        {
                            continue;
                        }

                        int colStart = worksheet.Dimension.Start.Column;    //工作区开始列
                        int colEnd = worksheet.Dimension.End.Column;        //工作区结束列
                        int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                        int rowEnd = worksheet.Dimension.End.Row;           //工作区结束行号

                        int v_template_row_index = 0;

                        //将每行&列添加到字典中
                        for (int i_row = rowStart; i_row <= rowEnd; i_row++)
                        {
                            for (int i_col = colStart; i_col <= colEnd; i_col++)
                            {
                                object value = worksheet.Cells[i_row, i_col].Value;
                                if (value == null)
                                {
                                    continue;
                                }

                                switch (value.ToString().Split('$').Count())
                                {
                                    case 3://表头
                                        dictHeader.Add(worksheet.Cells[i_row, i_col].Address, value.ToString());
                                        break;
                                    case 2://动态数据
                                        dictRows.Add(i_col, value.ToString());
                                        v_template_row_index = i_row;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        //设置标题值
                        foreach (var item in dictHeader)
                        {
                            worksheet.Cells[item.Key].Value = TitleKeyValue[item.Value.Split('$')[2]];
                        }

                        //判断是否有动态行，如果没有，继续下一个工作表
                        if (dictRows.Count == 0)
                        {
                            continue;
                        }

                        //动态行生成
                        int v_index = v_template_row_index;
                        foreach (T sub in list_data)
                        {
                            foreach (var item in dictRows)
                            {
                                //获取映射值
                                string t = item.Value.Split('$')[1];
                                Type Ts = sub.GetType();
                                object value = Ts.GetProperty(t).GetValue(sub, null);

                                //设置格式
                                worksheet.Cells[v_index, item.Key].StyleID = worksheet.Cells[v_template_row_index, item.Key].StyleID;

                                if (value != null)
                                {
                                    Ts = value.GetType();

                                    switch (Ts.Name)
                                    {
                                        case "DateTime":
                                            if ((DateTime)(value) == DateTime.MinValue || (DateTime)(value) == DateTime.MaxValue)
                                                value = null;
                                            worksheet.Cells[v_index, item.Key].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                                            break;
                                        case "String":
                                            if ((String)value == string.Empty)
                                                value = null;
                                            break;
                                    }
                                }

                                //设置值
                                worksheet.Cells[v_index, item.Key].Value = value;
                            }

                            v_index++;

                        }
                    }
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }

        static int ii = 0;
        public static string ExportSpreadsheet<T>(byte[] source, string destfilename, Dictionary<string, string>[] TitleKeyValue, List<T>[] list_data)
        {
            try
            {
                //复制模版文件
                File.WriteAllBytes(destfilename, source);
                FileInfo template = new FileInfo(destfilename);

                using (ExcelPackage package = new ExcelPackage(template))
                {
                    int ii = 0;
                    
                    ExcelWorksheets worksheets = package.Workbook.Worksheets;
                    //for (int ii = 0; ii < worksheets.Count; ii++)
                    //{
                        //ExcelWorksheet worksheet = worksheets.
                    foreach (var worksheet in worksheets)
                    {
                        Dictionary<string, string> dictHeader = new Dictionary<string, string>();//<"A1","$F$Title">
                        Dictionary<int, string> dictRows = new Dictionary<int, string>();//<"A1","F$Field">

                        //空表
                        if (worksheet.Dimension == null)
                        {
                            continue;
                        }

                        int colStart = worksheet.Dimension.Start.Column;    //工作区开始列
                        int colEnd = worksheet.Dimension.End.Column;        //工作区结束列
                        int rowStart = worksheet.Dimension.Start.Row;       //工作区开始行号
                        int rowEnd = worksheet.Dimension.End.Row;           //工作区结束行号

                        int v_template_row_index = 0;

                        //将每行&列添加到字典中
                        for (int i_row = rowStart; i_row <= rowEnd; i_row++)
                        {
                            for (int i_col = colStart; i_col <= colEnd; i_col++)
                            {
                                object value = worksheet.Cells[i_row, i_col].Value;
                                if (value == null)
                                {
                                    continue;
                                }

                                switch (value.ToString().Split('$').Count())
                                {
                                    case 3://表头
                                        dictHeader.Add(worksheet.Cells[i_row, i_col].Address, value.ToString());
                                        break;
                                    case 2://动态数据
                                        dictRows.Add(i_col, value.ToString());
                                        v_template_row_index = i_row;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        //设置标题值
                        foreach (var item in dictHeader)
                        {
                            worksheet.Cells[item.Key].Value = TitleKeyValue[ii][item.Value.Split('$')[2]];
                        }

                        //判断是否有动态行，如果没有，继续下一个工作表
                        if (dictRows.Count == 0)
                        {
                            ii++;
                            continue;
                        }

                        //动态行生成
                        int v_index = v_template_row_index;
                        foreach (T sub in list_data[ii])
                        {
                            foreach (var item in dictRows)
                            {
                                //获取映射值
                                string t = item.Value.Split('$')[1];
                                Type Ts = sub.GetType();
                                object value = Ts.GetProperty(t).GetValue(sub, null);

                                //设置格式
                                worksheet.Cells[v_index, item.Key].StyleID = worksheet.Cells[v_template_row_index, item.Key].StyleID;

                                if (value != null)
                                {
                                    Ts = value.GetType();

                                    switch (Ts.Name)
                                    {
                                        case "DateTime":
                                            if ((DateTime)(value) == DateTime.MinValue || (DateTime)(value) == DateTime.MaxValue)
                                                value = null;
                                            worksheet.Cells[v_index, item.Key].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                                            break;
                                        case "String":
                                            if ((String)value == string.Empty)
                                                value = null;
                                            break;
                                    }
                                }

                                //设置值
                                worksheet.Cells[v_index, item.Key].Value = value;
                            }

                            v_index++;

                        }
                        ii++;
                        if (ii >= list_data.Length || ii >= TitleKeyValue.Length)
                            break;
                    }
                    package.Save();
                    //ii = 0;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }
    }
}
