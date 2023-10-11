//
//  ViewController.swift
//  Calculator
//
//  Created by Heitor Bisneto on 07/07/21.
//  Copyright © 2021 Bisneto Inc. All rights reserved.
//

/*
 Tags Mark
 
 Button "0" = 1
 Button "1" = 2
 Button "2" = 3
 Button "3" = 4
 Button "4" = 5
 Button "5" = 6
 Button "6" = 7
 Button "7" = 8
 Button "8" = 9
 Button "9" = 10
 Button "C" = 11
 Button "/" = 12
 Button "X" = 13
 Button "-" = 14
 Button "+" = 15
 Button "=" = 16
 
 */

import UIKit

class ViewController: UIViewController {
    
    var NumberOnScreen: Double = 0;
    var PreviousNumber: Double = 0;
    var PerformMath = false;
    var Operation = 0;
    
    @IBOutlet weak var label: UILabel!
    
    @IBAction func numbers(_ sender: UIButton)
    {
        if PerformMath == true
        {
            label.text = String(sender.tag-1)
            NumberOnScreen = Double(label.text!)!;
            PerformMath = false;
        }
        else
        {
            label.text = label.text! + String(sender.tag-1)
            NumberOnScreen = Double(label.text!)!;
        }
    }
    
    @IBAction func buttons(_ sender: UIButton)
    {
        if label.text != "" && sender.tag != 11 && sender.tag != 16
        {
            PreviousNumber = Double(label.text!)!;
            
            if sender.tag == 12
            {
                label.text = "/"
            }
            else if sender.tag == 13
            {
                label.text = "x"
            }
            else if sender.tag == 14
            {
                label.text = "-"
            }
            else if sender.tag == 15
            {
                label.text = "+"
            }
            
            Operation = sender.tag;
            PerformMath = true;
        }
        else if sender.tag == 16
        {
            if Operation == 12
            {
                label.text = String(PreviousNumber / NumberOnScreen)
            }
            else if Operation == 13
            {
                label.text = String(PreviousNumber * NumberOnScreen)
            }
            else if Operation == 14
            {
                label.text = String(PreviousNumber - NumberOnScreen)
            }
            else if Operation == 15
            {
                label.text = String(PreviousNumber + NumberOnScreen)
            }
        }
        else if sender.tag == 11
        {
            label.text = "";
            PreviousNumber = 0;
            NumberOnScreen = 0;
            Operation = 0;
        }
    }

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

