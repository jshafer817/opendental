//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace OpenDentBusiness.WebTypes.WebForms.Crud{
	public class WebForms_SheetDefCrud {
		///<summary>Gets one WebForms_SheetDef object from the database using the primary key.  Returns null if not found.</summary>
		public static WebForms_SheetDef SelectOne(long webSheetDefID) {
			string command="SELECT * FROM webforms_sheetdef "
				+"WHERE WebSheetDefID = "+POut.Long(webSheetDefID);
			List<WebForms_SheetDef> list=TableToList(DataCore.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one WebForms_SheetDef object from the database using a query.</summary>
		public static WebForms_SheetDef SelectOne(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebForms_SheetDef> list=TableToList(DataCore.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of WebForms_SheetDef objects from the database using a query.</summary>
		public static List<WebForms_SheetDef> SelectMany(string command) {
			if(RemotingClient.RemotingRole==RemotingRole.ClientWeb) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebForms_SheetDef> list=TableToList(DataCore.GetTable(command));
			return list;
		}

		///<summary>Converts a list of WebForms_SheetDef into a DataTable.</summary>
		public static DataTable ListToTable(List<WebForms_SheetDef> listWebForms_SheetDefs,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="WebForms_SheetDef";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("WebSheetDefID");
			table.Columns.Add("DentalOfficeID");
			table.Columns.Add("Description");
			table.Columns.Add("SheetType");
			table.Columns.Add("FontSize");
			table.Columns.Add("FontName");
			table.Columns.Add("Width");
			table.Columns.Add("Height");
			table.Columns.Add("IsLandscape");
			table.Columns.Add("SheetDefNum");
			table.Columns.Add("HasMobileLayout");
			table.Columns.Add("ClinicNum");
			table.Columns.Add("RegistrationKeyNum");
			foreach(WebForms_SheetDef webForms_SheetDef in listWebForms_SheetDefs) {
				table.Rows.Add(new object[] {
					POut.Long  (webForms_SheetDef.WebSheetDefID),
					POut.Long  (webForms_SheetDef.DentalOfficeID),
					            webForms_SheetDef.Description,
					POut.Int   ((int)webForms_SheetDef.SheetType),
					POut.Float (webForms_SheetDef.FontSize),
					            webForms_SheetDef.FontName,
					POut.Int   (webForms_SheetDef.Width),
					POut.Int   (webForms_SheetDef.Height),
					POut.Bool  (webForms_SheetDef.IsLandscape),
					POut.Long  (webForms_SheetDef.SheetDefNum),
					POut.Bool  (webForms_SheetDef.HasMobileLayout),
					POut.Long  (webForms_SheetDef.ClinicNum),
					POut.Long  (webForms_SheetDef.RegistrationKeyNum),
				});
			}
			return table;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<WebForms_SheetDef> TableToList(DataTable table) {
			List<WebForms_SheetDef> retVal=new List<WebForms_SheetDef>();
			WebForms_SheetDef webForms_SheetDef;
			for(int i=0;i<table.Rows.Count;i++) {
				webForms_SheetDef=new WebForms_SheetDef();
				webForms_SheetDef.WebSheetDefID     = PIn.Long  (table.Rows[i]["WebSheetDefID"].ToString());
				webForms_SheetDef.DentalOfficeID    = PIn.Long  (table.Rows[i]["DentalOfficeID"].ToString());
				webForms_SheetDef.Description       = PIn.String(table.Rows[i]["Description"].ToString());
				webForms_SheetDef.SheetType         = (OpenDentBusiness.SheetTypeEnum)PIn.Int(table.Rows[i]["SheetType"].ToString());
				webForms_SheetDef.FontSize          = PIn.Float (table.Rows[i]["FontSize"].ToString());
				webForms_SheetDef.FontName          = PIn.String(table.Rows[i]["FontName"].ToString());
				webForms_SheetDef.Width             = PIn.Int   (table.Rows[i]["Width"].ToString());
				webForms_SheetDef.Height            = PIn.Int   (table.Rows[i]["Height"].ToString());
				webForms_SheetDef.IsLandscape       = PIn.Bool  (table.Rows[i]["IsLandscape"].ToString());
				webForms_SheetDef.SheetDefNum       = PIn.Long  (table.Rows[i]["SheetDefNum"].ToString());
				webForms_SheetDef.HasMobileLayout   = PIn.Bool  (table.Rows[i]["HasMobileLayout"].ToString());
				webForms_SheetDef.ClinicNum         = PIn.Long  (table.Rows[i]["ClinicNum"].ToString());
				webForms_SheetDef.RegistrationKeyNum= PIn.Long  (table.Rows[i]["RegistrationKeyNum"].ToString());
				retVal.Add(webForms_SheetDef);
			}
			return retVal;
		}

		///<summary>Inserts one WebForms_SheetDef into the database.  Returns the new priKey.</summary>
		public static long Insert(WebForms_SheetDef webForms_SheetDef) {
			return Insert(webForms_SheetDef,false);
		}

		///<summary>Inserts one WebForms_SheetDef into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(WebForms_SheetDef webForms_SheetDef,bool useExistingPK) {
			string command="INSERT INTO webforms_sheetdef (";
			if(useExistingPK) {
				command+="WebSheetDefID,";
			}
			command+="DentalOfficeID,Description,SheetType,FontSize,FontName,Width,Height,IsLandscape,SheetDefNum,HasMobileLayout,ClinicNum,RegistrationKeyNum) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webForms_SheetDef.WebSheetDefID)+",";
			}
			command+=
				     POut.Long  (webForms_SheetDef.DentalOfficeID)+","
				+"'"+POut.String(webForms_SheetDef.Description)+"',"
				+    POut.Int   ((int)webForms_SheetDef.SheetType)+","
				+    POut.Float (webForms_SheetDef.FontSize)+","
				+"'"+POut.String(webForms_SheetDef.FontName)+"',"
				+    POut.Int   (webForms_SheetDef.Width)+","
				+    POut.Int   (webForms_SheetDef.Height)+","
				+    POut.Bool  (webForms_SheetDef.IsLandscape)+","
				+    POut.Long  (webForms_SheetDef.SheetDefNum)+","
				+    POut.Bool  (webForms_SheetDef.HasMobileLayout)+","
				+    POut.Long  (webForms_SheetDef.ClinicNum)+","
				+    POut.Long  (webForms_SheetDef.RegistrationKeyNum)+")";
			if(useExistingPK) {
				DataCore.NonQ(command);
			}
			else {
				webForms_SheetDef.WebSheetDefID=DataCore.NonQ(command,true);
			}
			return webForms_SheetDef.WebSheetDefID;
		}

		///<summary>Inserts many WebForms_SheetDefs into the database.</summary>
		public static void InsertMany(List<WebForms_SheetDef> listWebForms_SheetDefs) {
			InsertMany(listWebForms_SheetDefs,false);
		}

		///<summary>Inserts many WebForms_SheetDefs into the database.  Provides option to use the existing priKey.</summary>
		public static void InsertMany(List<WebForms_SheetDef> listWebForms_SheetDefs,bool useExistingPK) {
			StringBuilder sbCommands=null;
			int index=0;
			int countRows=0;
			while(index < listWebForms_SheetDefs.Count) {
				WebForms_SheetDef webForms_SheetDef=listWebForms_SheetDefs[index];
				StringBuilder sbRow=new StringBuilder("(");
				bool hasComma=false;
				if(sbCommands==null) {
					sbCommands=new StringBuilder();
					sbCommands.Append("INSERT INTO webforms_sheetdef (");
					if(useExistingPK) {
						sbCommands.Append("WebSheetDefID,");
					}
					sbCommands.Append("DentalOfficeID,Description,SheetType,FontSize,FontName,Width,Height,IsLandscape,SheetDefNum,HasMobileLayout,ClinicNum,RegistrationKeyNum) VALUES ");
					countRows=0;
				}
				else {
					hasComma=true;
				}
				if(useExistingPK) {
					sbRow.Append(POut.Long(webForms_SheetDef.WebSheetDefID)); sbRow.Append(",");
				}
				sbRow.Append(POut.Long(webForms_SheetDef.DentalOfficeID)); sbRow.Append(",");
				sbRow.Append("'"+POut.String(webForms_SheetDef.Description)+"'"); sbRow.Append(",");
				sbRow.Append(POut.Int((int)webForms_SheetDef.SheetType)); sbRow.Append(",");
				sbRow.Append(POut.Float(webForms_SheetDef.FontSize)); sbRow.Append(",");
				sbRow.Append("'"+POut.String(webForms_SheetDef.FontName)+"'"); sbRow.Append(",");
				sbRow.Append(POut.Int(webForms_SheetDef.Width)); sbRow.Append(",");
				sbRow.Append(POut.Int(webForms_SheetDef.Height)); sbRow.Append(",");
				sbRow.Append(POut.Bool(webForms_SheetDef.IsLandscape)); sbRow.Append(",");
				sbRow.Append(POut.Long(webForms_SheetDef.SheetDefNum)); sbRow.Append(",");
				sbRow.Append(POut.Bool(webForms_SheetDef.HasMobileLayout)); sbRow.Append(",");
				sbRow.Append(POut.Long(webForms_SheetDef.ClinicNum)); sbRow.Append(",");
				sbRow.Append(POut.Long(webForms_SheetDef.RegistrationKeyNum)); sbRow.Append(")");
				if(sbCommands.Length+sbRow.Length+1 > TableBase.MaxAllowedPacketCount && countRows > 0) {
					DataCore.NonQ(sbCommands.ToString());
					sbCommands=null;
				}
				else {
					if(hasComma) {
						sbCommands.Append(",");
					}
					sbCommands.Append(sbRow.ToString());
					countRows++;
					if(index==listWebForms_SheetDefs.Count-1) {
						DataCore.NonQ(sbCommands.ToString());
					}
					index++;
				}
			}
		}

		///<summary>Updates one WebForms_SheetDef in the database.</summary>
		public static void Update(WebForms_SheetDef webForms_SheetDef) {
			string command="UPDATE webforms_sheetdef SET "
				+"DentalOfficeID    =  "+POut.Long  (webForms_SheetDef.DentalOfficeID)+", "
				+"Description       = '"+POut.String(webForms_SheetDef.Description)+"', "
				+"SheetType         =  "+POut.Int   ((int)webForms_SheetDef.SheetType)+", "
				+"FontSize          =  "+POut.Float (webForms_SheetDef.FontSize)+", "
				+"FontName          = '"+POut.String(webForms_SheetDef.FontName)+"', "
				+"Width             =  "+POut.Int   (webForms_SheetDef.Width)+", "
				+"Height            =  "+POut.Int   (webForms_SheetDef.Height)+", "
				+"IsLandscape       =  "+POut.Bool  (webForms_SheetDef.IsLandscape)+", "
				+"SheetDefNum       =  "+POut.Long  (webForms_SheetDef.SheetDefNum)+", "
				+"HasMobileLayout   =  "+POut.Bool  (webForms_SheetDef.HasMobileLayout)+", "
				+"ClinicNum         =  "+POut.Long  (webForms_SheetDef.ClinicNum)+", "
				+"RegistrationKeyNum=  "+POut.Long  (webForms_SheetDef.RegistrationKeyNum)+" "
				+"WHERE WebSheetDefID = "+POut.Long(webForms_SheetDef.WebSheetDefID);
			DataCore.NonQ(command);
		}

		///<summary>Updates one WebForms_SheetDef in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(WebForms_SheetDef webForms_SheetDef,WebForms_SheetDef oldWebForms_SheetDef) {
			string command="";
			if(webForms_SheetDef.DentalOfficeID != oldWebForms_SheetDef.DentalOfficeID) {
				if(command!="") { command+=",";}
				command+="DentalOfficeID = "+POut.Long(webForms_SheetDef.DentalOfficeID)+"";
			}
			if(webForms_SheetDef.Description != oldWebForms_SheetDef.Description) {
				if(command!="") { command+=",";}
				command+="Description = '"+POut.String(webForms_SheetDef.Description)+"'";
			}
			if(webForms_SheetDef.SheetType != oldWebForms_SheetDef.SheetType) {
				if(command!="") { command+=",";}
				command+="SheetType = "+POut.Int   ((int)webForms_SheetDef.SheetType)+"";
			}
			if(webForms_SheetDef.FontSize != oldWebForms_SheetDef.FontSize) {
				if(command!="") { command+=",";}
				command+="FontSize = "+POut.Float(webForms_SheetDef.FontSize)+"";
			}
			if(webForms_SheetDef.FontName != oldWebForms_SheetDef.FontName) {
				if(command!="") { command+=",";}
				command+="FontName = '"+POut.String(webForms_SheetDef.FontName)+"'";
			}
			if(webForms_SheetDef.Width != oldWebForms_SheetDef.Width) {
				if(command!="") { command+=",";}
				command+="Width = "+POut.Int(webForms_SheetDef.Width)+"";
			}
			if(webForms_SheetDef.Height != oldWebForms_SheetDef.Height) {
				if(command!="") { command+=",";}
				command+="Height = "+POut.Int(webForms_SheetDef.Height)+"";
			}
			if(webForms_SheetDef.IsLandscape != oldWebForms_SheetDef.IsLandscape) {
				if(command!="") { command+=",";}
				command+="IsLandscape = "+POut.Bool(webForms_SheetDef.IsLandscape)+"";
			}
			if(webForms_SheetDef.SheetDefNum != oldWebForms_SheetDef.SheetDefNum) {
				if(command!="") { command+=",";}
				command+="SheetDefNum = "+POut.Long(webForms_SheetDef.SheetDefNum)+"";
			}
			if(webForms_SheetDef.HasMobileLayout != oldWebForms_SheetDef.HasMobileLayout) {
				if(command!="") { command+=",";}
				command+="HasMobileLayout = "+POut.Bool(webForms_SheetDef.HasMobileLayout)+"";
			}
			if(webForms_SheetDef.ClinicNum != oldWebForms_SheetDef.ClinicNum) {
				if(command!="") { command+=",";}
				command+="ClinicNum = "+POut.Long(webForms_SheetDef.ClinicNum)+"";
			}
			if(webForms_SheetDef.RegistrationKeyNum != oldWebForms_SheetDef.RegistrationKeyNum) {
				if(command!="") { command+=",";}
				command+="RegistrationKeyNum = "+POut.Long(webForms_SheetDef.RegistrationKeyNum)+"";
			}
			if(command=="") {
				return false;
			}
			command="UPDATE webforms_sheetdef SET "+command
				+" WHERE WebSheetDefID = "+POut.Long(webForms_SheetDef.WebSheetDefID);
			DataCore.NonQ(command);
			return true;
		}

		///<summary>Deletes one WebForms_SheetDef from the database.</summary>
		public static void Delete(long webSheetDefID) {
			string command="DELETE FROM webforms_sheetdef "
				+"WHERE WebSheetDefID = "+POut.Long(webSheetDefID);
			DataCore.NonQ(command);
		}

	}
}