import { Component, ViewChild, ViewChildren, OnInit, AfterViewInit, AfterContentInit, QueryList } from '@angular/core';
import { GraphComponent, Layout } from "@swimlane/ngx-graph";
import { DagreNodesOnlyLayout } from './customDagreNodesOnly';
import * as shape from "d3-shape"
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit, AfterViewInit, AfterContentInit {
  ngAfterContentInit(): void {
    
  }
  ngAfterViewInit(): void {
    this.graph.first.nodeWidth = 200;
    this.graph.first.nodeHeight = 75;
  }
  ngOnInit(): void {
    console.log("loaded!");
  }
  public curve: any = shape.curveBasis;
  public layout: Layout = new DagreNodesOnlyLayout();
  
  @ViewChildren(GraphComponent)
  graph: QueryList<GraphComponent>;

  click(name: string) {
    alert(`Blah! ${name}`);
    
  }
}
