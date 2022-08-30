<script lang="ts">
	import { page } from '$app/stores';

	const currentYear = new Date().getFullYear();
	const mobileWidth = 796;

	// Navbar
	const navItems = [
		{ label: "ADMIN", href: "/admin"},
		{ label: "SØG", href: "/"},
	];

	// Page size
	$: innerWidth = 0;
</script>


<svelte:head>
	<!-- TITLE -->
	<title>INVENTAR | {$page.url.pathname === "/" ? "SØG" : $page.url.pathname.substring(1).toUpperCase()}</title>

	<!-- FONTS  -->
	<link rel="preconnect" href="https://fonts.googleapis.com">
	<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous">
	<link href="https://fonts.googleapis.com/css2?family=Bebas+Neue&family=Open+Sans:ital,wght@0,400;0,700;1,400;1,700&display=swap" rel="stylesheet">
</svelte:head>

<!-- Gets the width of the browser -->
<svelte:window bind:innerWidth />

<nav>
	<div id="navbar">
		<!-- Desktop navbar -->
		{#if innerWidth > mobileWidth}
			<div id="navbar-items">
				{#each navItems as navItem}
					<a class="navbar-item link-light" href={navItem.href}>{navItem.label}</a>
				{/each}
			</div>
		{/if}

		<!-- Logo -->
		<a href="/"><img id="logo" src="./images/logo.png" alt="ZBC logo"></a>
	</div>
</nav>

<!-- Page content -->
<div id="content">
	<slot></slot>
</div>

<footer>
	<p>All rights reserved.</p>
</footer>


<style>
	/* NAVBAR */
	nav {
		top: 0;
		z-index: 100;
		position: absolute;
		display: inline;
		font-size: 1.5rem;
		position: fixed;
		width: 100%;
	    font-family: 'Bebas Neue', cursive;
	}

	#navbar {
		height: 3.5em;
		background-color: var(--background-dark);
		position: relative;
	}

	#logo {
		margin-top: 0.21em;
		height: 3em;
		width: auto;
	}

	#navbar-items {
		padding-right: 1.5em;
	}

	.navbar-item {
		float: right;
		padding: 1.2em 0.5em 0.5em 0.5em;
		margin-left: 1.5em;
	}


	/* CONTENT */
	#content {
		margin: 8rem 2rem 2rem 2rem;
		font-size: 1.2rem;
		line-height: 1.9;
		background-color: var(--background);
		color: var(--text);
		border-radius: 3px;
		font-family: 'Open Sans', sans-serif;
	}


	/* FOOTER */
	footer {
		bottom: 0;
		width: 100%;
		height: 100%;
		padding: 1.5em;
		font-size: 1rem;
	    font-family: 'Open Sans', sans-serif;
		color: var(--text-light);
		background-color: var(--background-dark);
	}
</style>

