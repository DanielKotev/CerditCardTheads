package com.example.CreditCardThreads.Card;

import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@RestController
@CrossOrigin(origins = "*")
public class CardController {

    @PostMapping("/payment")
    public ResponseEntity<?> makePayment(@RequestBody CardRequest request) {
        try {
            return ResponseEntity.ok(Card.makePayment(request.getAmount()));
        } catch (Exception e) {
            return ResponseEntity.internalServerError().body("An error has occurred!");
        }
    }

    @PostMapping("/reset")
    public ResponseEntity<?> resetLimit() {
        return ResponseEntity.ok(Card.resetLimit());
    }
}
