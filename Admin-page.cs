

body {
    background-color: #f8f8f8;
}

#wrapper {
    width: 100%;
}

#page-wrapper {
    padding: 0 15px;
    min-height: 568px;
    background-color: #fff;
}

@media(min-width:768px) {
    #page-wrapper {
        position: inherit;
        margin: 0 0 0 250px;
        padding: 0 30px;
        border-left: 1px solid #e7e7e7;
    }
}

.navbar-top-links {
    margin-right: 0;
}

.navbar-top-links li {
    display: inline-block;
}

.navbar-top-links li:last-child {
    margin-right: 15px;
}

.navbar-top-links li a {
    padding: 15px;
    min-height: 50px;
}

.navbar-top-links .dropdown-menu li {
    display: block;
}

.navbar-top-links .dropdown-menu li:last-child {
    margin-right: 0;
}

.navbar-top-links .dropdown-menu li a {
    padding: 3px 20px;
    min-height: 0;
}

.navbar-top-links .dropdown-menu li a div {
    white-space: normal;
}

.navbar-top-links .dropdown-messages,
.navbar-top-links .dropdown-tasks,
.navbar-top-links .dropdown-alerts {
    width: 310px;
    min-width: 0;
}

.navbar-top-links .dropdown-messages {
    margin-left: 5px;
}

.navbar-top-links .dropdown-tasks {
    margin-left: -59px;
}

.navbar-top-links .dropdown-alerts {
    margin-left: -123px;
}

.navbar-top-links .dropdown-user {
    right: 0;
    left: auto;
}

.sidebar .sidebar-nav.navbar-collapse {
    padding-right: 0;
    padding-left: 0;
}

.sidebar .sidebar-search {
    padding: 15px;
}

.sidebar ul li {
    border-bottom: 1px solid #e7e7e7;
}

.sidebar ul li a.active {
    background-color: #eee;
}

.sidebar .arrow {
    float: right;
}

.sidebar .fa.arrow:before {
    content: "\f104";
}

.sidebar .active>a>.fa.arrow:before {
    content: "\f107";
}

.sidebar .nav-second-level li,
.sidebar .nav-third-level li {
    border-bottom: 0!important;
}

.sidebar .nav-second-level li a {
    padding-left: 37px;
}

.sidebar .nav-third-level li a {
    padding-left: 52px;
}

@media(min-width:768px) {
    .sidebar {
        z-index: 1;
        position: absolute;
        width: 250px;
        margin-top: 51px;
    }

    .navbar-top-links .dropdown-messages,
    .navbar-top-links .dropdown-tasks,
    .navbar-top-links .dropdown-alerts {
        margin-left: auto;
    }
}

.btn-outline {
    color: inherit;
    background-color: transparent;
    transition: all .5s;
}

.btn-primary.btn-outline {
    color: #428bca;
}

.btn-success.btn-outline {
    color: #5cb85c;
}

.btn-info.btn-outline {
    color: #5bc0de;
}

.btn-warning.btn-outline {
    color: #f0ad4e;
}

.btn-danger.btn-outline {
    color: #d9534f;
}

.btn-primary.btn-outline:hover,
.btn-success.btn-outline:hover,
.btn-info.btn-outline:hover,
.btn-warning.btn-outline:hover,
.btn-danger.btn-outline:hover {
    color: #fff;
}

.chat {
    margin: 0;
    padding: 0;
    list-style: none;
}

.chat li {
    margin-bottom: 10px;
    padding-bottom: 5px;
    border-bottom: 1px dotted #999;
}

.chat li.left .chat-body {
    margin-left: 60px;
}

.chat li.right .chat-body {
    margin-right: 60px;
}

.chat li .chat-body p {
    margin: 0;
}

.panel .slidedown .glyphicon,
.chat .glyphicon {
    margin-right: 5px;
}

.chat-panel .panel-body {
    height: 350px;
    overflow-y: scroll;
}

.login-panel {
    margin-top: 25%;
}

.flot-chart {
    display: block;
    height: 400px;
}

.flot-chart-content {
    width: 100%;
    height: 100%;
}

table.dataTable thead .sorting,
table.dataTable thead .sorting_asc,
table.dataTable thead .sorting_desc,
table.dataTable thead .sorting_asc_disabled,
table.dataTable thead .sorting_desc_disabled {
    background: 0 0;
}

table.dataTable thead .sorting_asc:after {
    content: "\f0de";
    float: right;
    font-family: fontawesome;
}

table.dataTable thead .sorting_desc:after {
    content: "\f0dd";
    float: right;
    font-family: fontawesome;
}

table.dataTable thead .sorting:after {
    content: "\f0dc";
    float: right;
    font-family: fontawesome;
    color: rgba(50,50,50,.5);
}

.btn-circle {
    width: 30px;
    height: 30px;
    padding: 6px 0;
    border-radius: 15px;
    text-align: center;
    font-size: 12px;
    line-height: 1.428571429;
}

.btn-circle.btn-lg {
    width: 50px;
    height: 50px;
    padding: 10px 16px;
    border-radius: 25px;
    font-size: 18px;
    line-height: 1.33;
}

.btn-circle.btn-xl {
    width: 70px;
    height: 70px;
    padding: 10px 16px;
    border-radius: 35px;
    font-size: 24px;
    line-height: 1.33;
}

.show-grid [class^=col-] {
    padding-top: 10px;
    padding-bottom: 10px;
    border: 1px solid #ddd;
    background-color: #eee!important;
}

.show-grid {
    margin: 15px 0;
}

.huge {
    font-size: 40px;
}

.panel-green {
    border-color: #5cb85c;
}

.panel-green .panel-heading {
    border-color: #5cb85c;
    color: #fff;
    background-color: #5cb85c;
}

.panel-green a {
    color: #5cb85c;
}

.panel-green a:hover {
    color: #3d8b3d;
}

.panel-red {
    border-color: #d9534f;
}

.panel-red .panel-heading {
    border-color: #d9534f;
    color: #fff;
    background-color: #d9534f;
}

.panel-red a {
    color: #d9534f;
}

.panel-red a:hover {
    color: #b52b27;
}

.panel-yellow {
    border-color: #f0ad4e;
}

.panel-yellow .panel-heading {
    border-color: #f0ad4e;
    color: #fff;
    background-color: #f0ad4e;
}

.panel-yellow a {
    color: #f0ad4e;
}

.panel-yellow a:hover {
    color: #df8a13;
}