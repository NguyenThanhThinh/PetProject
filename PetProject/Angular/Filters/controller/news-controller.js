app.controller('NewsController',
	function NewsController($scope) {
	    $scope.sortOrder = 'author';
	    $scope.news = {
	        name: 'ĐẠI HỌC CẦN THƠ',
	        content: 'Khoa Công nghệ Thông tin và Truyền thông (CNTT&TT) - Trường Đại học Cần Thơ được thành lập năm 1994 trên cơ sở Trung tâm Điện tử và Tin học. Nhiệm vụ  của khoa là đào tạo đại học, sau đại học, nghiên cứu khoa học và chuyển giao công nghệ trong lĩnh vực CNTT&TT.',
	        date: new Date(2014, 10, 12),
	        imageUrl: 'http://www.cit.ctu.edu.vn/images/cit/logo.jpg',
	        price: 22.3232432341,
	        author: {
	            name: 'Do Van Xe',
	            company: 'Can Tho University',
	            picture: 'http://www.cit.ctu.edu.vn/images/cit/khu2-khoa.jpg'
	        },
	        comments: [
				{
				    author: 'Thinh',
				    content: 'good',
				    date: new Date(2014, 12, 13, 12, 14).toDateString(),
				    votes: 0,
				},
				{
				    author: 'Nhan',
				    content: 'good',
				    date: new Date(2014, 12, 14, 13, 22).toDateString(),
				    votes: 0,
				},
				{
				    author: 'truc',
				    content: 'hihi',
				    date: new Date(2014, 12, 15, 13, 37).toDateString(),
				    votes: 0,
				},
				
	        ]
	    };

	    $scope.upVote = function upVote(comment) {
	        comment.votes += 1;
	    }

	    $scope.downVote = function downVote(comment) {
	        comment.votes -= 1;
	    }
	});