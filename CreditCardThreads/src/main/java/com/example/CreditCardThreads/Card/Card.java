package com.example.CreditCardThreads.Card;

public class Card {
    private static double limit = 10000;

    public static synchronized CardResponse makePayment(double amount) throws InterruptedException {
        CardResponse response;
        if (amount <= limit)
        {
            limit -= amount;
            response = new CardResponse("successful", limit);
        }
        else {
            response = new CardResponse("failed", limit);
        }

        Thread.sleep(1000);
        return response;
    }

    public static synchronized double resetLimit() {
        limit = 10000;
        return limit;
    }
}
