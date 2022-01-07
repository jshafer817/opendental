//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class DashboardARCrud {
		///<summary>Gets one DashboardAR object from the database using the primary key.  Returns null if not found.</summary>
		public static DashboardAR SelectOne(long dashboardARNum) {
			string command="SELECT * FROM dashboardar "
				+"WHERE DashboardARNum = "+POut.Long(dashboardARNum);
			List<DashboardAR> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one DashboardAR object from the database using a query.</summary>
		public static DashboardAR SelectOne(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<DashboardAR> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of DashboardAR objects from the database using a query.</summary>
		public static List<DashboardAR> SelectMany(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<DashboardAR> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<DashboardAR> TableToList(DataTable table) {
			List<DashboardAR> retVal=new List<DashboardAR>();
			DashboardAR dashboardAR;
			foreach(DataRow row in table.Rows) {
				dashboardAR=new DashboardAR();
				dashboardAR.DashboardARNum= PIn.Long  (row["DashboardARNum"].ToString());
				dashboardAR.DateCalc      = PIn.Date  (row["DateCalc"].ToString());
				dashboardAR.BalTotal      = PIn.Double(row["BalTotal"].ToString());
				dashboardAR.InsEst        = PIn.Double(row["InsEst"].ToString());
				retVal.Add(dashboardAR);
			}
			return retVal;
		}

		///<summary>Converts a list of DashboardAR into a DataTable.</summary>
		public static DataTable ListToTable(List<DashboardAR> listDashboardARs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="DashboardAR";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("DashboardARNum");
			table.Columns.Add("DateCalc");
			table.Columns.Add("BalTotal");
			table.Columns.Add("InsEst");
			foreach(DashboardAR dashboardAR in listDashboardARs) {
				table.Rows.Add(new object[] {
					POut.Long  (dashboardAR.DashboardARNum),
					POut.DateT (dashboardAR.DateCalc,false),
					POut.Double(dashboardAR.BalTotal),
					POut.Double(dashboardAR.InsEst),
				});
			}
			return table;
		}

		///<summary>Inserts one DashboardAR into the database.  Returns the new priKey.</summary>
		public static long Insert(DashboardAR dashboardAR) {
			return Insert(dashboardAR,false);
		}

		///<summary>Inserts one DashboardAR into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(DashboardAR dashboardAR,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				dashboardAR.DashboardARNum=ReplicationServers.GetKey("dashboardar","DashboardARNum");
			}
			string command="INSERT INTO dashboardar (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="DashboardARNum,";
			}
			command+="DateCalc,BalTotal,InsEst) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(dashboardAR.DashboardARNum)+",";
			}
			command+=
				     POut.Date  (dashboardAR.DateCalc)+","
				+		 POut.Double(dashboardAR.BalTotal)+","
				+		 POut.Double(dashboardAR.InsEst)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				dashboardAR.DashboardARNum=Db.NonQ(command,true,"DashboardARNum","dashboardAR");
			}
			return dashboardAR.DashboardARNum;
		}

		///<summary>Inserts one DashboardAR into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(DashboardAR dashboardAR) {
			return InsertNoCache(dashboardAR,false);
		}

		///<summary>Inserts one DashboardAR into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(DashboardAR dashboardAR,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO dashboardar (";
			if(!useExistingPK && isRandomKeys) {
				dashboardAR.DashboardARNum=ReplicationServers.GetKeyNoCache("dashboardar","DashboardARNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="DashboardARNum,";
			}
			command+="DateCalc,BalTotal,InsEst) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(dashboardAR.DashboardARNum)+",";
			}
			command+=
				     POut.Date  (dashboardAR.DateCalc)+","
				+	   POut.Double(dashboardAR.BalTotal)+","
				+	   POut.Double(dashboardAR.InsEst)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				dashboardAR.DashboardARNum=Db.NonQ(command,true,"DashboardARNum","dashboardAR");
			}
			return dashboardAR.DashboardARNum;
		}

		///<summary>Updates one DashboardAR in the database.</summary>
		public static void Update(DashboardAR dashboardAR) {
			string command="UPDATE dashboardar SET "
				+"DateCalc      =  "+POut.Date  (dashboardAR.DateCalc)+", "
				+"BalTotal      =  "+POut.Double(dashboardAR.BalTotal)+", "
				+"InsEst        =  "+POut.Double(dashboardAR.InsEst)+" "
				+"WHERE DashboardARNum = "+POut.Long(dashboardAR.DashboardARNum);
			Db.NonQ(command);
		}

		///<summary>Updates one DashboardAR in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(DashboardAR dashboardAR,DashboardAR oldDashboardAR) {
			string command="";
			if(dashboardAR.DateCalc.Date != oldDashboardAR.DateCalc.Date) {
				if(command!="") { command+=",";}
				command+="DateCalc = "+POut.Date(dashboardAR.DateCalc)+"";
			}
			if(dashboardAR.BalTotal != oldDashboardAR.BalTotal) {
				if(command!="") { command+=",";}
				command+="BalTotal = "+POut.Double(dashboardAR.BalTotal)+"";
			}
			if(dashboardAR.InsEst != oldDashboardAR.InsEst) {
				if(command!="") { command+=",";}
				command+="InsEst = "+POut.Double(dashboardAR.InsEst)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE dashboardar SET "+command
				+" WHERE DashboardARNum = "+POut.Long(dashboardAR.DashboardARNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(DashboardAR,DashboardAR) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(DashboardAR dashboardAR,DashboardAR oldDashboardAR) {
			if(dashboardAR.DateCalc.Date != oldDashboardAR.DateCalc.Date) {
				return true;
			}
			if(dashboardAR.BalTotal != oldDashboardAR.BalTotal) {
				return true;
			}
			if(dashboardAR.InsEst != oldDashboardAR.InsEst) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one DashboardAR from the database.</summary>
		public static void Delete(long dashboardARNum) {
			string command="DELETE FROM dashboardar "
				+"WHERE DashboardARNum = "+POut.Long(dashboardARNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many DashboardARs from the database.</summary>
		public static void DeleteMany(List<long> listDashboardARNums) {
			if(listDashboardARNums==null || listDashboardARNums.Count==0) {
				return;
			}
			string command="DELETE FROM dashboardar "
				+"WHERE DashboardARNum IN("+string.Join(",",listDashboardARNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}