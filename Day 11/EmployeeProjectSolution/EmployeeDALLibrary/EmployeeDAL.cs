using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModelsLibrary;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeDALLibrary
{
    public class EmployeeDAL
    {
        SqlConnection conn;
        public EmployeeDAL()
        {
            conn = myConnection.GetConnection();
        }

        public ICollection<Employee> GetAllEmployee()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            List<Employee> employees = new List<Employee>();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("proc_GetAllEmployee", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(ds);
            Employee employee;
            if (ds.Tables[0].Rows.Count != 0)
                throw new NoRecordException();

            foreach (DataRow item in ds.Tables[0].Rows)
                {
                    employee = new Employee();
                    employee.Id = Convert.ToInt32(item[0]);
                    employee.Name = item[1].ToString();
                    employee.Age = Convert.ToInt32(item[2]);
                    employees.Add(employee);
                }
                return employees;
           

        }
        public bool InsertNewEmployee(Employee employee)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            SqlCommand cmd = new SqlCommand("proc_AddEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ename", employee.Name);
            cmd.Parameters.AddWithValue("@eage", employee.Age);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                
                return true;
            }
            return false;
        }

        public bool UpdateEmployeeAge(Employee employee)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            SqlCommand cmd = new SqlCommand("proc_EditEmployeeAge", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", employee.Id);
            cmd.Parameters.AddWithValue("@ename", employee.Name);
            cmd.Parameters.AddWithValue("@eage", employee.Age);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
            
                return true;
            }
            return false;
        }

        public bool DeleteEmployee(int id)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            SqlCommand cmd = new SqlCommand("proc_DeleteEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", id);
            conn.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
               
                return true;
            }
            return false;
        }


    }
}
