import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog'
import { FormControl, FormGroup } from '@angular/forms';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    constructor(private router: Router) { }

    ngOnInit(): void {
    }

    form: FormGroup = new FormGroup({
        username: new FormControl(''),
        password: new FormControl(''),
      });
    
      submit() {
        if (this.form.valid) {
          this.submitEM.emit(this.form.value);
        }
      }
      @Input() error: string | null = '';
    
      @Output() submitEM = new EventEmitter();
}
