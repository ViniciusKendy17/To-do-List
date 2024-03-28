import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ParentDataComponent } from "./components/parent-data/parent-data.component";
import { HeaderComponent } from "./components/header/header.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, ParentDataComponent, HeaderComponent]
})
export class AppComponent {
    name = "japa";
}
