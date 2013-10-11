package atm;

import java.sql.*;

import sun.nio.cs.MS1250;

public class Account {
	
	private String account;
	private String aHolder;
	private String pin;
	private String balance;
	private boolean login = false;
	
	private Connection iConn;
	
	public Account(String account, String aHolder, String pin) throws ClassNotFoundException, SQLException {
		this.account = account;
		this.aHolder = aHolder;
		this.pin = pin;
		setupDatabaseConnection();
		setdb();
		login();
	}

	public String getBalance() {
		return balance;
	}

	public void setBalance(String balance) {
		this.balance = balance;
	}

	public String getAccount() {
		return account;
	}

	public String getaHolder() {
		return aHolder;
	}

	public String getPin() {
		return pin;
	}
	/**
	 * connect to server
	 * @throws ClassNotFoundException -driver fail
	 * @throws SQLException - fail to connect
	 */
	private void setupDatabaseConnection() throws ClassNotFoundException, SQLException {
			Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
			String URL = "jdbc:odbc:dv1454_ht13_5";
			String User = "dv1454_ht13_5";
			String Password = "pvdqVUv9";
			this.iConn = DriverManager.getConnection(URL, User, Password);
			System.out.println("coonected");
	}
	
	/**
	 * USE dv1454_ht13_5
	 * @throws SQLException
	 */
	
	private void setdb() throws SQLException{
		Statement stmt = iConn.createStatement();
		
		stmt.execute("USE dv1454_ht13_5 ");
		//ResultSetMetaData meta = res.getMetaData();
		//System.out.println("Number of columns: " + meta);
		//res.close();
		stmt.close();
		System.out.println("blb");
	}
	/**
	 * 
	 * @throws SQLException
	 */
	private void login() throws SQLException{
		//DECLARE @@r int = 0 EXEC confirmLoginAccess 1, 3123, 3
		System.out.println("LOGIN...");
		CallableStatement cs = null;
		cs = iConn.prepareCall("EXEC confirmLoginAccess ?, ?, ?, ? OUTPUT");
		cs.setInt(1, 1);
		cs.setInt(2, 3223);
		cs.setInt(3, 1);
		cs.registerOutParameter(4, Types.INTEGER);
		cs.execute();
		System.out.println(cs.getInt(4));
		//res.close();
		cs.close();
		//stmt.close();	
	}
	
	
}
