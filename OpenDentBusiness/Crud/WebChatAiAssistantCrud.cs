//This file is automatically generated.
//Do not attempt to make changes to this file because the changes will be erased and overwritten.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace OpenDentBusiness.Crud{
	public class WebChatAiAssistantCrud {
		///<summary>Gets one WebChatAiAssistant object from the database using the primary key.  Returns null if not found.</summary>
		public static WebChatAiAssistant SelectOne(long webChatAiAssistantNum) {
			string command="SELECT * FROM webchataiassistant "
				+"WHERE WebChatAiAssistantNum = "+POut.Long(webChatAiAssistantNum);
			List<WebChatAiAssistant> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets one WebChatAiAssistant object from the database using a query.</summary>
		public static WebChatAiAssistant SelectOne(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebChatAiAssistant> list=TableToList(Db.GetTable(command));
			if(list.Count==0) {
				return null;
			}
			return list[0];
		}

		///<summary>Gets a list of WebChatAiAssistant objects from the database using a query.</summary>
		public static List<WebChatAiAssistant> SelectMany(string command) {
			if(RemotingClient.MiddleTierRole==MiddleTierRole.ClientMT) {
				throw new ApplicationException("Not allowed to send sql directly.  Rewrite the calling class to not use this query:\r\n"+command);
			}
			List<WebChatAiAssistant> list=TableToList(Db.GetTable(command));
			return list;
		}

		///<summary>Converts a DataTable to a list of objects.</summary>
		public static List<WebChatAiAssistant> TableToList(DataTable table) {
			List<WebChatAiAssistant> retVal=new List<WebChatAiAssistant>();
			WebChatAiAssistant webChatAiAssistant;
			foreach(DataRow row in table.Rows) {
				webChatAiAssistant=new WebChatAiAssistant();
				webChatAiAssistant.WebChatAiAssistantNum= PIn.Long  (row["WebChatAiAssistantNum"].ToString());
				webChatAiAssistant.AssistantId          = PIn.String(row["AssistantId"].ToString());
				retVal.Add(webChatAiAssistant);
			}
			return retVal;
		}

		///<summary>Converts a list of WebChatAiAssistant into a DataTable.</summary>
		public static DataTable ListToTable(List<WebChatAiAssistant> listWebChatAiAssistants,string tableName="") {
			if(string.IsNullOrEmpty(tableName)) {
				tableName="WebChatAiAssistant";
			}
			DataTable table=new DataTable(tableName);
			table.Columns.Add("WebChatAiAssistantNum");
			table.Columns.Add("AssistantId");
			foreach(WebChatAiAssistant webChatAiAssistant in listWebChatAiAssistants) {
				table.Rows.Add(new object[] {
					POut.Long  (webChatAiAssistant.WebChatAiAssistantNum),
					            webChatAiAssistant.AssistantId,
				});
			}
			return table;
		}

		///<summary>Inserts one WebChatAiAssistant into the database.  Returns the new priKey.</summary>
		public static long Insert(WebChatAiAssistant webChatAiAssistant) {
			return Insert(webChatAiAssistant,false);
		}

		///<summary>Inserts one WebChatAiAssistant into the database.  Provides option to use the existing priKey.</summary>
		public static long Insert(WebChatAiAssistant webChatAiAssistant,bool useExistingPK) {
			string command="INSERT INTO webchataiassistant (";
			if(useExistingPK) {
				command+="WebChatAiAssistantNum,";
			}
			command+="AssistantId) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webChatAiAssistant.WebChatAiAssistantNum)+",";
			}
			command+=
				     DbHelper.ParamChar+"paramAssistantId)";
			if(webChatAiAssistant.AssistantId==null) {
				webChatAiAssistant.AssistantId="";
			}
			OdSqlParameter paramAssistantId=new OdSqlParameter("paramAssistantId",OdDbType.Text,POut.StringParam(webChatAiAssistant.AssistantId));
			if(useExistingPK) {
				Db.NonQ(command,paramAssistantId);
			}
			else {
				webChatAiAssistant.WebChatAiAssistantNum=Db.NonQ(command,true,"WebChatAiAssistantNum","webChatAiAssistant",paramAssistantId);
			}
			return webChatAiAssistant.WebChatAiAssistantNum;
		}

		///<summary>Inserts one WebChatAiAssistant into the database.  Returns the new priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebChatAiAssistant webChatAiAssistant) {
			return InsertNoCache(webChatAiAssistant,false);
		}

		///<summary>Inserts one WebChatAiAssistant into the database.  Provides option to use the existing priKey.  Doesn't use the cache.</summary>
		public static long InsertNoCache(WebChatAiAssistant webChatAiAssistant,bool useExistingPK) {
			string command="INSERT INTO webchataiassistant (";
			if(useExistingPK) {
				command+="WebChatAiAssistantNum,";
			}
			command+="AssistantId) VALUES(";
			if(useExistingPK) {
				command+=POut.Long(webChatAiAssistant.WebChatAiAssistantNum)+",";
			}
			command+=
				     DbHelper.ParamChar+"paramAssistantId)";
			if(webChatAiAssistant.AssistantId==null) {
				webChatAiAssistant.AssistantId="";
			}
			OdSqlParameter paramAssistantId=new OdSqlParameter("paramAssistantId",OdDbType.Text,POut.StringParam(webChatAiAssistant.AssistantId));
			if(useExistingPK) {
				Db.NonQ(command,paramAssistantId);
			}
			else {
				webChatAiAssistant.WebChatAiAssistantNum=Db.NonQ(command,true,"WebChatAiAssistantNum","webChatAiAssistant",paramAssistantId);
			}
			return webChatAiAssistant.WebChatAiAssistantNum;
		}

		///<summary>Updates one WebChatAiAssistant in the database.</summary>
		public static void Update(WebChatAiAssistant webChatAiAssistant) {
			string command="UPDATE webchataiassistant SET "
				+"AssistantId          =  "+DbHelper.ParamChar+"paramAssistantId "
				+"WHERE WebChatAiAssistantNum = "+POut.Long(webChatAiAssistant.WebChatAiAssistantNum);
			if(webChatAiAssistant.AssistantId==null) {
				webChatAiAssistant.AssistantId="";
			}
			OdSqlParameter paramAssistantId=new OdSqlParameter("paramAssistantId",OdDbType.Text,POut.StringParam(webChatAiAssistant.AssistantId));
			Db.NonQ(command,paramAssistantId);
		}

		///<summary>Updates one WebChatAiAssistant in the database.  Uses an old object to compare to, and only alters changed fields.  This prevents collisions and concurrency problems in heavily used tables.  Returns true if an update occurred.</summary>
		public static bool Update(WebChatAiAssistant webChatAiAssistant,WebChatAiAssistant oldWebChatAiAssistant) {
			string command="";
			if(webChatAiAssistant.AssistantId != oldWebChatAiAssistant.AssistantId) {
				if(command!="") { command+=",";}
				command+="AssistantId = "+DbHelper.ParamChar+"paramAssistantId";
			}
			if(command=="") {
				return false;
			}
			if(webChatAiAssistant.AssistantId==null) {
				webChatAiAssistant.AssistantId="";
			}
			OdSqlParameter paramAssistantId=new OdSqlParameter("paramAssistantId",OdDbType.Text,POut.StringParam(webChatAiAssistant.AssistantId));
			command="UPDATE webchataiassistant SET "+command
				+" WHERE WebChatAiAssistantNum = "+POut.Long(webChatAiAssistant.WebChatAiAssistantNum);
			Db.NonQ(command,paramAssistantId);
			return true;
		}

		///<summary>Returns true if Update(WebChatAiAssistant,WebChatAiAssistant) would make changes to the database.
		///Does not make any changes to the database and can be called before remoting role is checked.</summary>
		public static bool UpdateComparison(WebChatAiAssistant webChatAiAssistant,WebChatAiAssistant oldWebChatAiAssistant) {
			if(webChatAiAssistant.AssistantId != oldWebChatAiAssistant.AssistantId) {
				return true;
			}
			return false;
		}

		///<summary>Deletes one WebChatAiAssistant from the database.</summary>
		public static void Delete(long webChatAiAssistantNum) {
			string command="DELETE FROM webchataiassistant "
				+"WHERE WebChatAiAssistantNum = "+POut.Long(webChatAiAssistantNum);
			Db.NonQ(command);
		}

		///<summary>Deletes many WebChatAiAssistants from the database.</summary>
		public static void DeleteMany(List<long> listWebChatAiAssistantNums) {
			if(listWebChatAiAssistantNums==null || listWebChatAiAssistantNums.Count==0) {
				return;
			}
			string command="DELETE FROM webchataiassistant "
				+"WHERE WebChatAiAssistantNum IN("+string.Join(",",listWebChatAiAssistantNums.Select(x => POut.Long(x)))+")";
			Db.NonQ(command);
		}

	}
}