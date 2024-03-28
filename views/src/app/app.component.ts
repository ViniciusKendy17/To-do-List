import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TestComponent } from "./components/test/test.component";
import { ParentDataComponent } from "./components/parent-data/parent-data.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, TestComponent, ParentDataComponent]
})
export class AppComponent {
    name = "japa";
}
