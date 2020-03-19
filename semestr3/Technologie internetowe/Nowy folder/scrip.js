    var tab=[];
    var canvas = document.getElementById('loading');
    var ctx = canvas.getContext("2d");
    function Block(a, b, c, d, color)
        {
        this.a=a;
        this.b=b;
        this.c=c;
        this.d=d;
        this.color=color;
        this.db=1;
        this.tmp = function(c){
            this.color=c;
        }
        this.draw = function(){
            ctx.fillStyle = this.color;
            ctx.fillRect(this.a, this.b, this.c, this.d);
        }
        this.move_down = function(){
            this.b+=this.db;
            if(this.b+this.d>=canvas.height || this.b<10)
            {
                this.db=-1*this.db; 
            }
            this.draw();
        }
        }
    function start()
    {
        ctx.fillStyle = "white";
        ctx.fillRect(0,0,canvas.width,canvas.height);
        for(var i = 0; i < 6; i++)
        {
            tab.push(new Block(10+(i*40), (10*i+10), 30, 30, getRandomColor()));
            tab[i].draw();
        }
        for(var i=0; i < 6; i++)
        {
            interv(i, tab[i].a, tab[i].c);
        }
    }
    function getRandomColor() 
    {
        var letters = '0123456789ABCDEF';
        var color;
        do{
        color = '#';
        for (var i = 0; i < 6; i++) {
            color += letters[Math.floor(Math.random() * 16)];
        }
        }while(color=="#FFFFFF")
    return color;
    }
    function interv(index, a, c)
    {
        setInterval(function() {
            ctx.clearRect(a, 0, c, innerHeight);
            tab[index].move_down();
          }, 1000/60);
    }
    

