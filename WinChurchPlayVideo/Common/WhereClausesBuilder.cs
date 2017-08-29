using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace WinChurchPlayVideo.Common
{
    public class WhereClausesBuilder
    {
        public void appendCriteria(string parameterName, string value,
            string criteria, ref string where,
            ref List<SqlParameter> parameters)
        {
            appendCriteria(parameterName, value, criteria,
                ref where, ref parameters, SqlDbType.Char);
        }
        public void appendCriteria(string parameterName, string value,
            string criteria, ref string where,
            ref List<SqlParameter> parameters, SqlDbType dbType)
        {

            if (string.IsNullOrEmpty(value)) return;

            string cond = string.Format(criteria, "@" + parameterName);
            where += " AND " + cond;

            var p = new SqlParameter(parameterName, dbType);
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
