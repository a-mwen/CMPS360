import javax.swing.JOptionPane;

public class Random {
    
    public static void main(String[] args) {
        //generate a random number output using the "showMessageDiaglog" method 
        int randomNumber = (int)  (Math.random() * 100) + 1;

        JOptionPane.showMessageDialog(null, "Random Number: "+ randomNumber);
    }
}
