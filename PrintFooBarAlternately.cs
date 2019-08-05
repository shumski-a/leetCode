using System.Threading;

public class FooBar {
    private int n;
    private static bool canPrintFoo = true;
    public FooBar(int n) {
        this.n = n;
        
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            while(!canPrintFoo)
             Thread.Sleep(0);
        	printFoo();
            canPrintFoo = false;
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
        while (canPrintFoo)
            Thread.Sleep(0);
       	printBar();
        canPrintFoo = true;
        }
    }
}