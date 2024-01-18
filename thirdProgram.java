import javax.swing.JOptionPane;

public class thirdProgram {
    public static void main(String[] args) {

        int startingNumber = 23;
        String results;
        String inputRequest;
        //Asks user for input of guess
        results = JOptionPane.showInputDialog(null,  "Guess the lucky number ");


        //Logic for input value

        if(startingNumber == Integer.parseInt(results)) {
            inputRequest = "Great guess";
        } else{
            inputRequest = "Sorry try again";
        }

        //output end result
        JOptionPane.showMessageDialog(null, inputRequest);


    }

}
