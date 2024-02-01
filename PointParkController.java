package com.example.springboot;

import java.time.LocalDate;
import java.time.LocalTime;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class PointParkController {

    private boolean isBradyFan = true; 
    private int numberOfWeeksAtHome = 30;

    @RequestMapping("/point")
    public String point() {
        if (isBradyFan) {
            return "Welcome to Bison Country";
        } else {
            return "Welcome to Generic Point";
        }
    }


    @RequestMapping("/about")
    public String about() {
        if (isBradyFan || numberOfWeeksAtHome <= 10) {
            return "This story is about a man named Brady.";
        } else {
            return "This story is about an interesting character.";
        }
    }

    @RequestMapping("/home")
    public String home() {
        LocalDate currentDate = LocalDate.now();
        if (currentDate.getDayOfYear() % 2 == 0) {
            return "200 Wood Street is my home on even days of the year";
        } else {
            return "200 Wood Street is my home on odd days of the year";
        }
    }

    @RequestMapping("/fun")
    public String fun() {
        LocalTime currentTime = LocalTime.now();
        if (currentTime.getHour() < 18) {
            return "Having fun at Point Park! Join the daytime party!";
        } else {
            return "Having fun at Point Park! Join the nighttime party!";
        }
    }
}
