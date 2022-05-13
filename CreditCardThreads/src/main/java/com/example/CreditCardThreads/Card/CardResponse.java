package com.example.CreditCardThreads.Card;

public class CardResponse {
    private String status;
    private double limit;

    public CardResponse(String status, double limit) {
        this.status = status;
        this.limit = limit;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public double getLimit() {
        return limit;
    }

    public void setLimit(double limit) {
        this.limit = limit;
    }
}
