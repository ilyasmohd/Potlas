using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dropdownlist2.Items.Insert(0, new ListItem() { Text = "--select--", Value = "-1" });
            dropdownlist2.DataBind();
        }
    }

    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    {
        Response.Write("text changed event fired");
        object o = DropDownList1.SelectedItem;
        object o1 = DropDownList1.SelectedValue;
        object o2 = DropDownList1.SelectedIndex;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write("index changed event fired");
        object o = DropDownList1.SelectedItem;
        ListItem list = new ListItem();
        list = DropDownList1.SelectedItem;
        object o1 = DropDownList1.SelectedValue;
        object o2 = DropDownList1.SelectedIndex;
    }

    //protected void bindDepartments()
    //{
    //    SqlConnection strcon1 = new SqlConnection(strcon);
    //    strcon1.Open();
    //    string ADDStr = "SELECT DepartmentId,DepartmentName FROM Departments ";
    //    SqlCommand ADDCmd = new SqlCommand(ADDStr, strcon1);
    //    DataTable table = new DataTable();


    //    SqlDataAdapter adapter = new SqlDataAdapter(ADDCmd);

    //    adapter.Fill(table);

    //    ddlDepartments.DataSource = table;
    //    ddlDepartments.DataValueField = "DepartmentId"; //The Value of the DropDownList, to get it you should call ddlDepartments.SelectedValue;
    //    ddlDepartments.DataTextField = "DepartmentName"; //The Name shown of the DropDownList.
    //    ddlDepartments.DataBind();

    //}
}