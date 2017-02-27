import javax.swing.*;
public class SwingMenu {
    public static void main(String[] args) 
{
       SwingMenu s=new SwingMenu();
    }
public SwingMenu()
{
 JFrame frame=new JFrame("Sample Menubar");
frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
JMenuBar menubar=new JMenuBar();
JMenu filemenu=new JMenu("File");
filemenu.add(new JSeparator());
JMenu editmenu=new JMenu("Edit");
editmenu.add(new JSeparator());
JMenuItem fileItem1=new JMenuItem("New");
fileItem1.add(new JSeparator());
JMenuItem fileItem2=new JMenuItem("Open");
fileItem2.add(new JSeparator());
JMenuItem fileItem3=new JMenuItem("Save");
fileItem3.add(new JSeparator());
JMenuItem fileItem4=new JMenuItem("Close");
fileItem4.add(new JSeparator());
JMenuItem editItem1=new JMenuItem("Cut");
editItem1.add(new JSeparator());
JMenuItem editItem2=new JMenuItem("Copy");
editItem2.add(new JSeparator());
JMenuItem editItem3=new JMenuItem("Paste");
editItem3.add(new JSeparator());
JMenuItem editItem4=new JMenuItem("Insert");
editItem4.add(new JSeparator());
filemenu.add(fileItem1);
filemenu.add(fileItem2);
filemenu.add(fileItem3);
filemenu.add(fileItem4);
editmenu.add(editItem1);
editmenu.add(editItem2);
editmenu.add(editItem3);
editmenu.add(editItem4);
menubar.add(filemenu);
menubar.add(editmenu);
frame.setJMenuBar(menubar);
frame.setVisible(true);
frame.setSize(500,500);

}
}
