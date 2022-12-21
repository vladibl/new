package java_home_work;
import java.util.Collections;
import java.util.LinkedList;
import java.util.SimpleTimeZone;
import java.util.logging.Logger;

public class reversegb {
    public static void main(String[] args) {
        LinkedList<Integer> ls = new LinkedList<Integer>();

        for (int i = 0; i < 10; i++) {
            ls.add(i);
        }

        Logger log = Logger.getAnonymousLogger();
        log.info(ls.toString());
        Collections.reverse(ls);
        log.info(ls.toString());


    }
}
