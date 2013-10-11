package atm;

import java.awt.Panel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;


public class atmGUI extends JFrame {

	private class Action implements ActionListener{
		@Override
		public void actionPerformed(ActionEvent e) {
			System.out.println(e.getActionCommand());
			System.out.println(lPassword.getPassword());
			//System.out.println(l);
			System.out.println(lUsername.getText().contains("@"));
			if (e.getActionCommand().equals("Login")){
				if(lUsername.getText().contains("@")){
					System.out.println("@ ok");
					if(!(lPassword.getPassword().length == 0)){
						System.out.println(lPassword.getPassword());
						String uId , aId;
						uId = lUsername.getText().substring(0,lUsername.getText().indexOf('@'));
						System.out.println(uId);
						aId = lUsername.getText().substring(lUsername.getText().indexOf('@')+1);
						System.out.println(aId);
					}
				}
			}
			if (e.getActionCommand().equals("With Draw")){
				//login.removeAll();
				remove(withDraw);
				//removeAll();
				login();
				add(login);
				revalidate();
				repaint();
				System.out.println("-");
			}
		}
	}
	
	//login
	private JPanel login = new JPanel(null);
	private JTextField lUsername = new JTextField("accountHolderID@accountID");
	private JPasswordField lPassword = new JPasswordField();
	private JButton lLogin = new JButton("Login");
	//------------
	//withDraw
	private JPanel withDraw = new JPanel(null);
	private JTextField wAmount = new JTextField("100");
	private JLabel wBalance = new JLabel();
	private JButton wWithDraw = new JButton("With Draw");
	//-----------
	
	atmGUI(){
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		config();
		init();
		render(1);
	}
	
	private void config(){
		//JFrame
		setSize(800, 600);
		setLocationRelativeTo(null);
		
	}
	
	private void init() {
		
	}
	
	private void login() { 	//login == 1
		lUsername.setLocation(250, 230);
		lUsername.setSize(300, 26);
		lUsername.setHorizontalAlignment(JTextField.CENTER);
		
		lPassword.setLocation(250, 260);
		lPassword.setSize(300,26);
		lPassword.setHorizontalAlignment(JTextField.CENTER);
		
		//jLabel
		JLabel u = new JLabel("User Name:");
		JLabel p = new JLabel("Password:");
		u.setSize(u.getPreferredSize());
		p.setSize(p.getPreferredSize());
		
		u.setLocation(lUsername.getLocation().x-u.getPreferredSize().width-4, lUsername.getLocation().y+4);
		p.setLocation(lPassword.getLocation().x-p.getPreferredSize().width-4, lPassword.getLocation().y+4);
		
		lLogin.addActionListener(new Action());
		lLogin.setLocation(367, 300);
		lLogin.setSize(lLogin.getPreferredSize());
		System.out.println(lLogin.getPreferredSize());
		login.add(lUsername);
		login.add(lPassword);
		login.add(u);
		login.add(p);
		login.add(lLogin);
	}
	
	private void withDraw(){
		wBalance.setText("10221.12");
		wBalance.setHorizontalAlignment(JLabel.CENTER);
		wBalance.setSize(150,26);
		wBalance.setLocation((getSize().width/2)-(wBalance.getSize().width/2), 230);
		
		//wAmount.setText("");
		wAmount.setHorizontalAlignment(JTextField.CENTER);
		wAmount.setSize(150, 26);
		wAmount.setLocation((getSize().width/2)-(wBalance.getSize().width/2), 260);
		
		wWithDraw.addActionListener(new Action());
		wWithDraw.setSize(wWithDraw.getPreferredSize());
		wWithDraw.setLocation((getSize().width/2)-(wWithDraw.getSize().width/2),300);
		
		withDraw.add(wBalance);
		withDraw.add(wAmount);
		withDraw.add(wWithDraw);
		
	}
	
	private void render(int choose){
		withDraw();
		add(withDraw);
	}

}
