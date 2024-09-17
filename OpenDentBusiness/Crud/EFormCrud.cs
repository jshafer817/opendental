//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class EFormCrud {
		///<summary>Gets one EForm object from the database using the primary key.  Returns null if not found.</summary>
		public static EForm SelectOne(long eFormNum) {
			string command="SELECT * FROM eform "
				+"WHERE EFormNum = "+POut.Long(eFormNum);
			List<EForm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one EForm object from the database using a query.</summary>
		public static EForm SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<EForm> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of EForm objects from the database using a query.</summary>
		public static List<EForm> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<EForm> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<EForm> TableToList(DataTable table) {
			List<EForm> retVal=new List<EForm>();
			EForm eForm;
			foreach(DataRow row in table.Rows) {
				eForm=new EForm();
				eForm.EFormNum     = PIn.Long  (row["EFormNum"].ToString());
				eForm.FormType     = (OpenDentBusiness.EnumEFormType)PIn.Int(row["FormType"].ToString());
				eForm.PatNum       = PIn.Long  (row["PatNum"].ToString());
				eForm.DateTimeShown= PIn.DateT (row["DateTimeShown"].ToString());
				eForm.Description  = PIn.String(row["Description"].ToString());
				eForm.DateTEdited  = PIn.DateT (row["DateTEdited"].ToString());
				eForm.MaxWidth     = PIn.Int   (row["MaxWidth"].ToString());
				retVal.Add(eForm);
			}
			return retVal;
		}

		///<summary>Converts a list of EForm into a DataTable.</summary>
		public static DataTable ListToTable(List<EForm> listEForms,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="EForm";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("EFormNum");
			table.Columns.Add("FormType");
			table.Columns.Add("PatNum");
			table.Columns.Add("DateTimeShown");
			table.Columns.Add("Description");
			table.Columns.Add("DateTEdited");
			table.Columns.Add("MaxWidth");
			foreach(EForm eForm in listEForms) {
				table.Rows.Add(new object[] {
					POut.Long  (eForm.EFormNum),
					POut.Int   ((int)eForm.FormType),
					POut.Long  (eForm.PatNum),
					POut.DateT (eForm.DateTimeShown,false),
					            eForm.Description,
					POut.DateT (eForm.DateTEdited,false),
					POut.Int   (eForm.MaxWidth),
				});
			}
			return table;
		}

		///<summary>Inserts one EForm into the database.  Returns the new priKey.</summary>
		public static long Insert(EForm eForm) {
			return Insert(eForm,false);
		}

		///<summary>Inserts one EForm into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(EForm eForm,bool useExistingPK) {
			if(!useExistingPK && PrefC.RandomKeys) {
				eForm.EFormNum=ReplicationServers.GetKey("eform","EFormNum");
			}
			string command="INSERT INTO eform (";
			if(useExistingPK || PrefC.RandomKeys) {
				command+="EFormNum,";
			}
			command+="FormType,PatNum,DateTimeShown,Description,DateTEdited,MaxWidth) VALUES(";
			if(useExistingPK || PrefC.RandomKeys) {
				command+=POut.Long(eForm.EFormNum)+",";
			}
			command+=
				     POut.Int   ((int)eForm.FormType)+","
				+    POut.Long  (eForm.PatNum)+","
				+    POut.DateT (eForm.DateTimeShown)+","
				+"'"+POut.String(eForm.Description)+"',"
				+    POut.DateT (eForm.DateTEdited)+","
				+    POut.Int   (eForm.MaxWidth)+")";
			if(useExistingPK || PrefC.RandomKeys) {
				Db.NonQ(command);
			}
			else {
				eForm.EFormNum=Db.NonQ(command,true,"EFormNum","eForm");
			}
			return eForm.EFormNum;
		}

		///<summary>Inserts one EForm into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(EForm eForm) {
			return InsertNoCache(eForm,false);
		}

		///<summary>Inserts one EForm into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(EForm eForm,bool useExistingPK) {
			bool isRandomKeys=Prefs.GetBoolNoCache(PrefName.RandomPrimaryKeys);
			string command="INSERT INTO eform (";
			if(!useExistingPK && isRandomKeys) {
				eForm.EFormNum=ReplicationServers.GetKeyNoCache("eform","EFormNum");
			}
			if(isRandomKeys || useExistingPK) {
				command+="EFormNum,";
			}
			command+="FormType,PatNum,DateTimeShown,Description,DateTEdited,MaxWidth) VALUES(";
			if(isRandomKeys || useExistingPK) {
				command+=POut.Long(eForm.EFormNum)+",";
			}
			command+=
				     POut.Int   ((int)eForm.FormType)+","
				+    POut.Long  (eForm.PatNum)+","
				+    POut.DateT (eForm.DateTimeShown)+","
				+"'"+POut.String(eForm.Description)+"',"
				+    POut.DateT (eForm.DateTEdited)+","
				+    POut.Int   (eForm.MaxWidth)+")";
			if(useExistingPK || isRandomKeys) {
				Db.NonQ(command);
			}
			else {
				eForm.EFormNum=Db.NonQ(command,true,"EFormNum","eForm");
			}
			return eForm.EFormNum;
		}

		///<summary>Updates one EForm in the database.</summary>
		public static void Update(EForm eForm) {
			string command="UPDATE eform SET "
				+"FormType     =  "+POut.Int   ((int)eForm.FormType)+", "
				+"PatNum       =  "+POut.Long  (eForm.PatNum)+", "
				+"DateTimeShown=  "+POut.DateT (eForm.DateTimeShown)+", "
				+"Description  = '"+POut.String(eForm.Description)+"', "
				+"DateTEdited  =  "+POut.DateT (eForm.DateTEdited)+", "
				+"MaxWidth     =  "+POut.Int   (eForm.MaxWidth)+" "
				+"WHERE EFormNum = "+POut.Long(eForm.EFormNum);
			Db.NonQ(command);
		}

		///<summary>Updates one EForm in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(EForm eForm,EForm oldEForm) {
			string command="";
			if(eForm.FormType != oldEForm.FormType) {
				if(command!="") { command+=",";}
				command+="FormType = "+POut.Int   ((int)eForm.FormType)+"";
			}
			if(eForm.PatNum != oldEForm.PatNum) {
				if(command!="") { command+=",";}
				command+="PatNum = "+POut.Long(eForm.PatNum)+"";
			}
			if(eForm.DateTimeShown != oldEForm.DateTimeShown) {
				if(command!="") { command+=",";}
				command+="DateTimeShown = "+POut.DateT(eForm.DateTimeShown)+"";
			}
			if(eForm.Description != oldEForm.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(eForm.Description)+"'";
			}
			if(eForm.DateTEdited != oldEForm.DateTEdited) {
				if(command!="") { command+=",";}
				command+="DateTEdited = "+POut.DateT(eForm.DateTEdited)+"";
			}
			if(eForm.MaxWidth != oldEForm.MaxWidth) {
				if(command!="") { command+=",";}
				command+="MaxWidth = "+POut.Int(eForm.MaxWidth)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE eform SET "+command
				+" WHERE EFormNum = "+POut.Long(eForm.EFormNum);
			Db.NonQ(command);
			return true;
		}

		///<summary>Returns true if Update(EForm,EForm) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(EForm eForm,EForm oldEForm) {
			if(eForm.FormType != oldEForm.FormType) {
				return true;
			}
			if(eForm.PatNum != oldEForm.PatNum) {
				return true;
			}
			if(eForm.DateTimeShown != oldEForm.DateTimeShown) {
				return true;
			}
			if(eForm.Description != oldEForm.Description) {
				return true;
			}
			if(eForm.DateTEdited != oldEForm.DateTEdited) {
				return true;
			}
			if(eForm.MaxWidth != oldEForm.MaxWidth) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one EForm from the database.</summary>
		public static void Delete(long eFormNum) {
			string command="DELETE FROM eform "
				+"WHERE EFormNum = "+POut.Long(eFormNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many EForms from the database.</summary>
		public static void DeleteMany(List<long> listEFormNums) {
			if(listEFormNums==null || listEFormNums.Count==0) {
				return;
			}
			string command="DELETE FROM eform "
				+"WHERE EFormNum IN("+string.Join(",",listEFormNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}