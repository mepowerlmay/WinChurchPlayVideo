using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace WinChurchPlayVideo.Common
{
    public class WhereClausesBuilder
    {
        public void appendCriteria(string parameterName, string value,
            string criteria, ref string where,
            ref List<OleDbParameter> parameters)
        {
            appendCriteria(parameterName, value, criteria,
                ref where, ref parameters,  OleDbType .Char);
        }
        public void appendCriteria(string parameterName, string value,
            string criteria, ref string where,
            ref List<OleDbParameter> parameters, OleDbType dbType)
        {

            if (string.IsNullOrEmpty(value)) return;

            string cond = string.Format(criteria, "@" + parameterName);
            where += " AND " + cond;

            var p = new OleDbParameter(parameterName, dbType);
            p.Value = value;
            parameters.Add(p);
        }

        public void appendCriteria(string dtStart, string dtEnd,
            string columnName, ref string where)
        {
            //todo
        }

        public string generateWhereClauses(string where)
        {
            if (string.IsNullOrEmpty(where)) return "";
            return where.Substring(5);

        }
    }
}
